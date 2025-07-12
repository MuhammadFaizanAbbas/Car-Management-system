using FYP_PROJECT.Helpers.CommonHelpers;
using MySql.Data.MySqlClient;
using System;

namespace FYP_PROJECT.Helpers.AdminHelpers
{ 
public static class DashboardHelper
{
    public static DashboardSummary GetDashboardSummary()
    {
        DashboardSummary summary = new DashboardSummary();

            using (MySqlConnection conn = DatabaseConnectionHelper.GetConnection())
            {
            conn.Open();

            // Query 1: This Month Income = sum of total from completed appointments this month
            string queryThisMonthIncome = @"
                SELECT IFNULL(SUM(Appointment_Grand_Total), 0)
                FROM appointment
                WHERE Appointment_Status = 'Complete' AND MONTH(Appointment_Date) = MONTH(CURDATE()) AND YEAR(Appointment_Date) = YEAR(CURDATE());";

            using (MySqlCommand cmd = new MySqlCommand(queryThisMonthIncome, conn))
            {
                summary.ThisMonthIncome = Convert.ToDecimal(cmd.ExecuteScalar());
            }

            // Query 2: This Year Income (sum from income table for current year)
            string queryThisYearIncome = @"
                SELECT IFNULL(SUM(Income_Amount), 0)
                FROM income
                WHERE YEAR(Income_Date) = YEAR(CURDATE());";

            using (MySqlCommand cmd = new MySqlCommand(queryThisYearIncome, conn))
            {
                summary.ThisYearIncome = Convert.ToDecimal(cmd.ExecuteScalar());
            }

            // Query 3: Total services done (count of appointments with status complete)
            string queryTotalServicesDone = @"
                SELECT COUNT(*)
                FROM appointment
                WHERE Appointment_Status = 'Complete';";

            using (MySqlCommand cmd = new MySqlCommand(queryTotalServicesDone, conn))
            {
                summary.TotalServicesDone = Convert.ToInt32(cmd.ExecuteScalar());
            }

            // Query 4: Total employees (count in employees table)
            string queryTotalEmployees = @"
                SELECT COUNT(*)
                FROM employees;";

            using (MySqlCommand cmd = new MySqlCommand(queryTotalEmployees, conn))
            {
                summary.TotalEmployees = Convert.ToInt32(cmd.ExecuteScalar());
            }

                // Query 5: Monthly salaries (sum of salaries from employees table)
                string queryMonthlySalaries = @"
                SELECT IFNULL(SUM(CAST(REPLACE(TRIM(Employee_Salary), ',', '') AS UNSIGNED)), 0)
                FROM employees;";
                using (MySqlCommand cmd = new MySqlCommand(queryMonthlySalaries, conn))
            {
                summary.MonthlySalaries = Convert.ToDecimal(cmd.ExecuteScalar());
            }

            // Query 6: Total profit = sum(income) - sum(expenses)
            string queryProfit = @"
                SELECT 
                    IFNULL((SELECT SUM(Income_Amount) FROM income), 0) - 
                    IFNULL((SELECT SUM(Expense_Amount) FROM expenses), 0) AS Profit;";

            using (MySqlCommand cmd = new MySqlCommand(queryProfit, conn))
            {
                summary.TotalProfit = Convert.ToDecimal(cmd.ExecuteScalar());
            }
        }

        return summary;
    }
}
}
