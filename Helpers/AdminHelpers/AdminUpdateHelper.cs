using FYP_PROJECT.Helpers.CommonHelpers;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace FYP_PROJECT.Helpers.AdminHelpers
{
    public static class AdminUpdateHelper
    {

        public static bool UpdateAdminProfile(
            string name, string username, string password, string email, string phone,
            string securityQuestion, string securityAnswer)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnectionHelper.GetConnection())
                {
                    conn.Open();

                    string updateQuery = @"
                        UPDATE users
                        SET 
                            User_Name = @name,
                            User_UserName = @username,
                            User_Password = @password,
                            User_Email = @email,
                            User_PhoneNumber = @phone,
                            User_SecurityQuestions = @question,
                            User_SecurityAnswer = @answer
                        WHERE 
                            User_Name = @oldName AND
                            User_UserName = @oldUsername AND
                            User_Password = @oldPassword AND
                            User_Email = @oldEmail AND
                            User_PhoneNumber = @oldPhone AND
                            User_Cnic = @oldCnic AND
                            User_Account_Type = 'Admin'";

                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                    {
                        // New values to be updated
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@question", securityQuestion);
                        cmd.Parameters.AddWithValue("@answer", securityAnswer);

                        // Conditions using session values
                        cmd.Parameters.AddWithValue("@oldName", Session.Name);
                        cmd.Parameters.AddWithValue("@oldUsername", Session.Username);
                        cmd.Parameters.AddWithValue("@oldPassword", Session.Password);
                        cmd.Parameters.AddWithValue("@oldEmail", Session.Email);
                        cmd.Parameters.AddWithValue("@oldPhone", Session.PhoneNumber);
                        cmd.Parameters.AddWithValue("@oldCnic", Session.Cnic);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Update Session values after DB update
                            Session.Name = name;
                            Session.Username = username;
                            Session.Password = password;
                            Session.Email = email;
                            Session.PhoneNumber = phone;
                            Session.SecurityQuestion = securityQuestion;
                            Session.SecurityAnswer = securityAnswer;

                            return true;
                        }

                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating admin: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
