using System;
using System.Windows.Forms;
using FYP_PROJECT.Helpers.CommonHelpers;
using MySql.Data.MySqlClient;

namespace FYP_PROJECT.Helpers.EmployeeHelpers
{
    public class AppointmentService
    {
        public bool MarkAppointmentAsComplete(int appointmentId, out string message)
        {
            message = "";
            using (MySqlConnection conn = DatabaseConnectionHelper.GetConnection())
            {
                try
                {
                    conn.Open();

                    // 1. Get grand total
                    string selectQuery = "SELECT Appointment_Grand_Total FROM appointment WHERE Appointment_Id = @appointmentId";
                    decimal grandTotal = 0;

                    using (MySqlCommand selectCmd = new MySqlCommand(selectQuery, conn))
                    {
                        selectCmd.Parameters.AddWithValue("@appointmentId", appointmentId);
                        object result = selectCmd.ExecuteScalar();

                        if (result == null || !decimal.TryParse(result.ToString(), out grandTotal))
                        {
                            message = "Could not retrieve appointment total.";
                            return false;
                        }
                    }

                    // 2. Update status
                    string updateQuery = "UPDATE appointment SET Appointment_Status = 'Complete' WHERE Appointment_Id = @appointmentId";
                    using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@appointmentId", appointmentId);
                        int rowsAffected = updateCmd.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            message = "Failed to update the appointment status.";
                            return false;
                        }
                    }

                    // 3. Insert into income
                    string insertIncomeQuery = @"
                        INSERT INTO income (Income_Source, Income_Amount, Income_Date, Income_Appointment_Id)
                        VALUES ('Appointment', @amount, @date, @appointmentId)";

                    using (MySqlCommand incomeCmd = new MySqlCommand(insertIncomeQuery, conn))
                    {
                        incomeCmd.Parameters.AddWithValue("@amount", grandTotal);
                        incomeCmd.Parameters.AddWithValue("@date", DateTime.Now.Date);
                        incomeCmd.Parameters.AddWithValue("@appointmentId", appointmentId);
                        incomeCmd.ExecuteNonQuery();
                    }

                    message = "Appointment marked as complete and income recorded.";
                    return true;
                }
                catch (Exception ex)
                {
                    message = "Error: " + ex.Message;
                    return false;
                }
            }
        }
    }
}
