using System;
using System.Windows.Forms;
using FYP_PROJECT.Helpers.CommonHelpers;
using MySql.Data.MySqlClient;

namespace FYP_PROJECT.Helpers.EmployeeHelpers
{
    public class AiDetectionService
    {
        public bool SaveDetection(string issue, string suggestion, out string message)
        {
            message = "";
            try
            {
                using (MySqlConnection conn = DatabaseConnectionHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"INSERT INTO ai_detections (Ai_Issue, Ai_Suggestion, Ai_Date) 
                                     VALUES (@issue, @suggestion, @date)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@issue", issue);
                        cmd.Parameters.AddWithValue("@suggestion", suggestion);
                        cmd.Parameters.AddWithValue("@date", DateTime.Now.Date);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            message = "AI Detection saved successfully!";
                            return true;
                        }
                        else
                        {
                            message = "Failed to save AI detection.";
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                message = "Database Error: " + ex.Message;
                return false;
            }
        }
    }
}
