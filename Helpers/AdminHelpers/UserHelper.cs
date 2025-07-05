using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using FYP_PROJECT.Helpers.CommonHelpers;

namespace FYP_PROJECT.Helpers.AdminHelpers
{
    public static class UserHelper
    {
        public static void LoadAllUsersToGrid(DataGridView targetGrid)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnectionHelper.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            User_id AS 'ID',
                            User_Employee_Id AS 'Employee ID',
                            User_Account_Type AS 'Account Type',
                            User_Name AS 'Name',
                            User_UserName AS 'Username',
                            User_Password AS 'Password',
                            User_Occupation AS 'Occupation',
                            User_Email AS 'Email',
                            User_PhoneNumber AS 'Phone Number',
                            User_Cnic AS 'CNIC',
                            User_SecurityQuestions AS 'Security Question',
                            User_SecurityAnswer AS 'Security Answer'
                        FROM users";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        targetGrid.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
