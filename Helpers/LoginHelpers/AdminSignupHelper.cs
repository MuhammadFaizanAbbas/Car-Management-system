using FYP_PROJECT.Helpers.CommonHelpers;
using MySql.Data.MySqlClient;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FYP_PROJECT.Helpers.LoginHelpers
{
    public static class AdminSignupHelper
    {
        private static readonly string[] AllowedDesignations =
        {
            "CEO", "Manager", "Supervisor", "Head", "Lead",
            "Assistant Manager", "Owner","Admin Staff","Operations Lead","Receptionist Manager","Inventory Manager","Accoutant"
        };
        public static bool RegisterAdmin(
            string name, string username, string password, string email,
            string phone, string cnic, string question, string answer)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnectionHelper.GetConnection())
                {
                    conn.Open();

                    // Step 1: Check CNIC in employees table
                    string checkQuery = "SELECT Employee_Id, Employee_Role FROM employees WHERE Employee_Cnic = @cnic";
                    using (MySqlCommand cmd = new MySqlCommand(checkQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@cnic", cnic);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("CNIC not found in employee records.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return false;
                            }

                            int employeeId = Convert.ToInt32(reader["Employee_Id"]);
                            string role = reader["Employee_Role"].ToString();

                            bool isAuthorized = AllowedDesignations.Any(d =>
                                role.IndexOf(d, StringComparison.OrdinalIgnoreCase) >= 0);

                            if (!isAuthorized)
                            {
                                MessageBox.Show("Only managerial-level employees can register as Admin.", "Unauthorized", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }

                            reader.Close();

                            // Step 2: Insert into users table
                            string insertQuery = @"INSERT INTO users
                                (User_Employee_Id, User_Account_type, User_Name, User_UserName, User_Password,
                                 User_Occupation, User_Email, User_PhoneNumber, User_Cnic,
                                 User_SecurityQuestions, User_SecurityAnswer)
                                 VALUES
                                (@empId, 'Admin', @name, @username, @password, @role,
                                 @email, @phone, @cnic, @question, @answer)";

                            using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                            {
                                insertCmd.Parameters.AddWithValue("@empId", employeeId);
                                insertCmd.Parameters.AddWithValue("@name", name);
                                insertCmd.Parameters.AddWithValue("@username", username);
                                insertCmd.Parameters.AddWithValue("@password", password); // optionally hash
                                insertCmd.Parameters.AddWithValue("@role", role);
                                insertCmd.Parameters.AddWithValue("@email", email);
                                insertCmd.Parameters.AddWithValue("@phone", phone);
                                insertCmd.Parameters.AddWithValue("@cnic", cnic);
                                insertCmd.Parameters.AddWithValue("@question", question);
                                insertCmd.Parameters.AddWithValue("@answer", answer);

                                int rows = insertCmd.ExecuteNonQuery();

                                if (rows > 0)
                                {
                                    MessageBox.Show("Admin account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return true;
                                }
                                else
                                {
                                    MessageBox.Show("Failed to create admin account.", "Insert Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return false;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
