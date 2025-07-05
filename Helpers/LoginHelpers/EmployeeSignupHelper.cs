using FYP_PROJECT.Helpers.CommonHelpers;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace FYP_PROJECT.Helpers.LoginHelpers
{
    public static class EmployeeSignupHelper
    {
        public static bool RegisterEmployee(
            string name, string username, string password, string email,
            string phone, string cnic, string question, string answer)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnectionHelper.GetConnection())
                {
                    conn.Open();

                    // Step 1: Check if CNIC exists and fetch Employee_Id and Role (occupation)
                    string checkQuery = "SELECT Employee_Id, Employee_Role FROM employees WHERE Employee_Cnic = @cnic";
                    int employeeId;
                    string occupation;

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

                            employeeId = reader.GetInt32("Employee_Id");
                            occupation = reader.GetString("Employee_Role"); // use as is
                        }
                    }

                    // Step 2: Insert new user record
                    string insertQuery = @"INSERT INTO users
                        (User_Employee_Id, User_Account_type, User_Name, User_UserName, User_Password,
                         User_Occupation, User_Email, User_PhoneNumber, User_Cnic,
                         User_SecurityQuestions, User_SecurityAnswer)
                        VALUES
                        (@empId, 'Employee', @name, @username, @password,
                         @occupation, @email, @phone, @cnic, @question, @answer)";

                    using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@empId", employeeId);
                        insertCmd.Parameters.AddWithValue("@name", name);
                        insertCmd.Parameters.AddWithValue("@username", username);
                        insertCmd.Parameters.AddWithValue("@password", password); // optional: hash it
                        insertCmd.Parameters.AddWithValue("@occupation", occupation);
                        insertCmd.Parameters.AddWithValue("@email", email);
                        insertCmd.Parameters.AddWithValue("@phone", phone);
                        insertCmd.Parameters.AddWithValue("@cnic", cnic);
                        insertCmd.Parameters.AddWithValue("@question", question);
                        insertCmd.Parameters.AddWithValue("@answer", answer);

                        int rows = insertCmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Employee account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Failed to create employee account.", "Insert Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
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
