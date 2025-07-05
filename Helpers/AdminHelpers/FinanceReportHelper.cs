using FYP_PROJECT.Helpers.CommonHelpers;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace FYP_PROJECT.Helpers.AdminHelpers
{
    public static class FinanceReportHelper
    {
        public static bool LoadIncomeAndExpenseData(int month, int year,
            out DataTable incomeTable, out DataTable expenseTable,
            out decimal totalIncome, out decimal totalExpense)
        {
            incomeTable = new DataTable();
            expenseTable = new DataTable();
            totalIncome = 0;
            totalExpense = 0;

            try
            {
                using (MySqlConnection conn = DatabaseConnectionHelper.GetConnection())
                {
                    conn.Open();

                    // Income Query
                    string incomeQuery = @"
                        SELECT Income_Id, Income_Source, Income_Amount, Income_Date, Income_Appointment_Id 
                        FROM income 
                        WHERE MONTH(Income_Date) = @month AND YEAR(Income_Date) = @year";

                    using (MySqlCommand cmd = new MySqlCommand(incomeQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@month", month);
                        cmd.Parameters.AddWithValue("@year", year);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(incomeTable);
                        }

                        foreach (DataRow row in incomeTable.Rows)
                        {
                            totalIncome += Convert.ToDecimal(row["Income_Amount"]);
                        }
                    }

                    // Expense Query
                    string expenseQuery = @"
                        SELECT Expense_Id, Expense_Discription, Expense_Amount, Expense_Date 
                        FROM expenses 
                        WHERE MONTH(Expense_Date) = @month AND YEAR(Expense_Date) = @year";

                    using (MySqlCommand cmd = new MySqlCommand(expenseQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@month", month);
                        cmd.Parameters.AddWithValue("@year", year);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(expenseTable);
                        }

                        foreach (DataRow row in expenseTable.Rows)
                        {
                            totalExpense += Convert.ToDecimal(row["Expense_Amount"]);
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching income/expense data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
