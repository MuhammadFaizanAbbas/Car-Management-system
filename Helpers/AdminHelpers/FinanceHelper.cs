using FYP_PROJECT.Helpers.CommonHelpers;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace FYP_PROJECT.Helpers.AdminHelpers
{
    public static class FinanceHelper
    {
        

        public static void LoadIncomeData(DataGridView incomeGrid)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnectionHelper.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            a.Appointment_Id AS 'Appointment ID',
                            c.Client_Name AS 'Client Name',
                            a.Appointment_Date AS 'Date',
                            a.Appointment_Grand_Total AS 'Grand Total',
                            a.Appointment_Pay_Method AS 'Payment Method',
                            a.Appointment_Status AS 'Status'
                        FROM appointment a
                        INNER JOIN clients c ON a.Appointment_Client_Id = c.Client_Id
                        WHERE a.Appointment_Grand_Total > 0";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        incomeGrid.DataSource = dt;

                        // Format currency column
                        if (incomeGrid.Columns.Contains("Grand Total"))
                        {
                            incomeGrid.Columns["Grand Total"].DefaultCellStyle.Format = "C0"; // Currency format
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading income data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
