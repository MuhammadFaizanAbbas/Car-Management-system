using System;
using System.Data;
using FYP_PROJECT.Helpers.CommonHelpers;
using MySql.Data.MySqlClient;

namespace FYP_PROJECT.Helpers.EmployeeHelpers
{
    public static class DatabaseHelper
    {
        
        public static void SaveAIResultToDatabase(string issues, string suggestion)
        {
            using (MySqlConnection conn = DatabaseConnectionHelper.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO ai_detection (Ai_Issues, Ai_Suggestion, Ai_Date) VALUES (@issues, @suggestion, @date)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@issues", issues);
                        cmd.Parameters.AddWithValue("@suggestion", suggestion);
                        cmd.Parameters.AddWithValue("@date", DateTime.Now.Date);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error saving AI result: " + ex.Message);
                }
            }
        }
    }
}