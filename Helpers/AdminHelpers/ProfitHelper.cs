using MySql.Data.MySqlClient;
using System;
using System.Globalization;
using System.Windows.Forms;
using FYP_PROJECT.Helpers.CommonHelpers;

namespace FYP_PROJECT.Helpers.AdminHelpers
{
    public static class ProfitHelper
    {
        public static void LoadMonthlyProfit(string monthName, Label profitLabel)
        {
            int selectedMonth = DateTime.ParseExact(monthName, "MMMM", CultureInfo.InvariantCulture).Month;
            int currentYear = DateTime.Now.Year;

            decimal totalIncome = 0;
            decimal totalExpense = 0;

            try
            {
                using (MySqlConnection conn = DatabaseConnectionHelper.GetConnection())
                {
                    conn.Open();

                    // Income Query
                    string incomeQuery = @"
                        SELECT IFNULL(SUM(Income_Amount), 0) 
                        FROM income 
                        WHERE MONTH(Income_Date) = @month AND YEAR(Income_Date) = @year";

                    using (MySqlCommand incomeCmd = new MySqlCommand(incomeQuery, conn))
                    {
                        incomeCmd.Parameters.AddWithValue("@month", selectedMonth);
                        incomeCmd.Parameters.AddWithValue("@year", currentYear);
                        totalIncome = Convert.ToDecimal(incomeCmd.ExecuteScalar());
                    }

                    // Expense Query
                    string expenseQuery = @"
                        SELECT IFNULL(SUM(Expense_Amount), 0) 
                        FROM expenses 
                        WHERE MONTH(Expense_Date) = @month AND YEAR(Expense_Date) = @year";

                    using (MySqlCommand expenseCmd = new MySqlCommand(expenseQuery, conn))
                    {
                        expenseCmd.Parameters.AddWithValue("@month", selectedMonth);
                        expenseCmd.Parameters.AddWithValue("@year", currentYear);
                        totalExpense = Convert.ToDecimal(expenseCmd.ExecuteScalar());
                    }

                    decimal profit = totalIncome - totalExpense;
                    profitLabel.Text = "Rs " + profit.ToString("N0"); // Thousands formatted
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating monthly profit: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
