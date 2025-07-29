using FYP_PROJECT.Helpers.CommonHelpers;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace FYP_PROJECT.Helpers.AdminHelpers
{


    public static class AppointmentHelper
    {
        public static void LoadTodayAppointments(DataGridView targetGrid)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnectionHelper.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            a.Appointment_Id AS 'ID',
                            c.Client_Name AS 'Client Name',
                            a.Appointment_Date AS 'Date',
                            a.Appointment_Total AS 'Total',
                            a.Appointment_Discount AS 'Discount',
                            a.Appointment_Grand_Total AS 'Grand Total',
                            a.Appointment_Pay_Method AS 'Payment Method',
                            a.Appointment_Status AS 'Status'
                        FROM appointment a
                        INNER JOIN clients c ON a.Appointment_Client_Id = c.Client_Id
                        WHERE DATE(a.Appointment_Date) = CURDATE()
                        ORDER BY a.Appointment_Date DESC";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        targetGrid.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading today's appointments:\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void LoadAppointmentsThisMonth(DataGridView targetGrid)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnectionHelper.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            a.Appointment_Id AS 'ID',
                            c.Client_Name AS 'Client Name',
                            a.Appointment_Date AS 'Date',
                            a.Appointment_Total AS 'Total',
                            a.Appointment_Discount AS 'Discount',
                            a.Appointment_Grand_Total AS 'Grand Total',
                            a.Appointment_Pay_Method AS 'Payment Method',
                            a.Appointment_Status AS 'Status'
                        FROM appointment a
                        INNER JOIN clients c ON a.Appointment_Client_Id = c.Client_Id
                        WHERE MONTH(a.Appointment_Date) = MONTH(CURDATE())
                          AND YEAR(a.Appointment_Date) = YEAR(CURDATE())
                        ORDER BY a.Appointment_Date DESC";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        targetGrid.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading this month's appointments:\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void LoadCompletedAppointments(DataGridView targetGrid)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnectionHelper.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            a.Appointment_Id AS 'ID',
                            c.Client_Name AS 'Client Name',
                            a.Appointment_Date AS 'Date',
                            a.Appointment_Total AS 'Total',
                            a.Appointment_Discount AS 'Discount',
                            a.Appointment_Grand_Total AS 'Grand Total',
                            a.Appointment_Pay_Method AS 'Payment Method',
                            a.Appointment_Status AS 'Status'
                        FROM appointment a
                        INNER JOIN clients c ON a.Appointment_Client_Id = c.Client_Id
                        WHERE a.Appointment_Status = 'Complete'
                        ORDER BY a.Appointment_Date DESC";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        targetGrid.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading completed appointments:\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static int LoadAlertAppointments(DataGridView targetGrid)
        {
            int count = 0;

            try
            {
                using (MySqlConnection conn = DatabaseConnectionHelper.GetConnection())
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    a.Appointment_Id AS 'ID',
                    a.Appointment_Date AS 'DATE',
                    a.Appointment_Total AS 'TOTAL',
                    a.Appointment_Grand_Total AS 'GRAND TOTAL',
                    a.Appointment_Pay_Method AS 'PAY METHOD',
                    a.Appointment_Status AS 'STATUS',
                    c.Client_Name AS 'CLIENT NAME',
                    c.Client_Phone AS 'PHONE',
                    c.Client_Car_Number AS 'CAR NUMBER',
                    c.Client_Car_Model AS 'CAR MODEL',
                    c.Client_Car_Make AS 'CAR MAKE',
                    c.Client_Car_Year AS 'CAR YEAR'
                FROM appointment a
                INNER JOIN clients c ON a.Appointment_Client_Id = c.Client_id
                WHERE a.Appointment_Alert = '1'";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        targetGrid.DataSource = dt;
                        count = dt.Rows.Count;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading alert appointments: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return count;
        }
    }
}
