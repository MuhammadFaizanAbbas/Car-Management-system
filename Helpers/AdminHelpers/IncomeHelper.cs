using System;
using System.Collections.Generic;
using System.Globalization;
using FYP_PROJECT.Helpers.CommonHelpers;
using MySql.Data.MySqlClient;

namespace FYP_PROJECT.Helpers.AdminHelpers
{
    public static class IncomeHelper
    {
        public static Dictionary<string, double> GetServicesDoneThisMonth()
        {
            var servicesByDate = new Dictionary<string, double>();

            DateTime firstDay = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            int daysInMonth = DateTime.DaysInMonth(firstDay.Year, firstDay.Month);

            // Pre-fill dictionary for all days of the current month with 0
            for (int i = 0; i < daysInMonth; i++)
            {
                var date = firstDay.AddDays(i);
                servicesByDate[date.ToString("MMM dd")] = 0;
            }

            using (var conn = DatabaseConnectionHelper.GetConnection())
            using (var cmd = new MySqlCommand(@"
        SELECT Income_Date AS ServiceDay,
               COUNT(*) AS TotalServices
        FROM income
        WHERE Income_Date >= @StartOfMonth
          AND Income_Date < @StartOfNextMonth
          AND Income_Source = 'appointment'
        GROUP BY ServiceDay
        ORDER BY ServiceDay ASC", conn))
            {
                cmd.Parameters.AddWithValue("@StartOfMonth", firstDay);
                cmd.Parameters.AddWithValue("@StartOfNextMonth", firstDay.AddMonths(1));

                conn.Open();
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        DateTime date = rdr.GetDateTime("ServiceDay");
                        double count = rdr.IsDBNull(rdr.GetOrdinal("TotalServices")) ? 0 : rdr.GetInt32("TotalServices");
                        servicesByDate[date.ToString("MMM dd")] = count;
                    }
                }
            }

            return servicesByDate;
        }
        public static Dictionary<string, double> GetLast30DaysIncome()
        {
            var incomeByDate = new Dictionary<string, double>();

            // Pre-fill dictionary for all 30 days with zero income to avoid missing days
            for (int i = 30; i >= 0; i--)
            {
                var date = DateTime.Today.AddDays(-i);
                incomeByDate[date.ToString("MMM dd")] = 0;
            }

            using (var conn = DatabaseConnectionHelper.GetConnection())
            using (var cmd = new MySqlCommand(@"
        SELECT DATE(Income_Date) AS IncomeDay,
               SUM(Income_Amount) AS Total
        FROM income
        WHERE Income_Date >= CURDATE() - INTERVAL 30 DAY
        GROUP BY IncomeDay
        ORDER BY IncomeDay ASC", conn))
            {
                conn.Open();
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        DateTime date = rdr.GetDateTime("IncomeDay");
                        double amount = rdr.IsDBNull(rdr.GetOrdinal("Total")) ? 0 : rdr.GetDouble("Total");
                        incomeByDate[date.ToString("MMM dd")] = amount;
                    }
                }
            }

            return incomeByDate;
        }
        public static Dictionary<string, double> GetYearlyIncomeByMonth()
        {
            var incomeByMonth = new Dictionary<string, double>();

            try
            {
                using (MySqlConnection conn = DatabaseConnectionHelper.GetConnection())
                using (var cmd = new MySqlCommand(@"
                    SELECT MONTH(Income_Date) AS MonthNum, 
                           SUM(CAST(Income_Amount AS UNSIGNED)) AS Total
                    FROM income
                    WHERE YEAR(Income_Date) = YEAR(CURDATE())
                    GROUP BY MonthNum
                    ORDER BY MonthNum", conn))
                {
                    conn.Open();
                    using (var rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            int monthNum = rdr.GetInt32("MonthNum");

                            double amount = 0;
                            if (!rdr.IsDBNull(rdr.GetOrdinal("Total")))
                                amount = rdr.GetDouble("Total");

                            string monthName = CultureInfo.CurrentCulture
                                .DateTimeFormat
                                .GetAbbreviatedMonthName(monthNum); // Jan, Feb...

                            incomeByMonth[monthName] = amount;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log this if needed or handle gracefully
                System.Windows.Forms.MessageBox.Show("Failed to load income chart: " + ex.Message);
            }

            return incomeByMonth;
        }
    }
}
