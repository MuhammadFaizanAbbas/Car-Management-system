using FYP_PROJECT.Helpers.CommonHelpers;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace FYP_PROJECT.Helpers.AdminHelpers
{
    public static class UserUpdateHelper
    {
        public static bool UpdateUserFromGrid(
            // New values from textboxes
            string newName, string newUsername, string newPassword,
            string newEmail, string newPhone, string newOccupation,
            string newSecurityQuestion, string newSecurityAnswer, string newAccountType,

            // Old values from selected row
            int userId           
        )
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnectionHelper.GetConnection())
                {
                    conn.Open();

                    string updateQuery = @"
                        UPDATE users SET
                            User_Name = @newName,
                            User_UserName = @newUsername,
                            User_Password = @newPassword,
                            User_Email = @newEmail,
                            User_PhoneNumber = @newPhone,
                            User_Occupation = @newOccupation,
                            User_SecurityQuestions = @newSecurityQuestion,
                            User_SecurityAnswer = @newSecurityAnswer,
                            User_Account_type = @newAccountType
                        WHERE 
                            User_id = @userId";

                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                    {
                        // New values
                        cmd.Parameters.AddWithValue("@newName", newName);
                        cmd.Parameters.AddWithValue("@newUsername", newUsername);
                        cmd.Parameters.AddWithValue("@newPassword", newPassword);
                        cmd.Parameters.AddWithValue("@newEmail", newEmail);
                        cmd.Parameters.AddWithValue("@newPhone", newPhone);
                        cmd.Parameters.AddWithValue("@newOccupation", newOccupation);
                        cmd.Parameters.AddWithValue("@newSecurityQuestion", newSecurityQuestion);
                        cmd.Parameters.AddWithValue("@newSecurityAnswer", newSecurityAnswer);
                        cmd.Parameters.AddWithValue("@newAccountType", newAccountType);

                        cmd.Parameters.AddWithValue("@userId", userId);


                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + "\n\nStackTrace:\n" + ex.StackTrace,
                                "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
