using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using FYP_PROJECT.Helpers.CommonHelpers;

namespace FYP_PROJECT.Helpers.AdminHelpers
{
    public static class ExpenseHelper
    {
        public static void LoadExpenseData(DataGridView targetGrid)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnectionHelper.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            Expense_Id AS 'ID',
                            Expense_Discription AS 'Description',
                            Expense_Amount AS 'Amount (Rs)',
                            Expense_Date AS 'Date'
                        FROM expenses
                        ORDER BY Expense_Date DESC";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        targetGrid.DataSource = dt;

                        // Optional styling
                        targetGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                        targetGrid.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                        targetGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading expense data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
