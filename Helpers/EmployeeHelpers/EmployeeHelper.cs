using FYP_PROJECT.Helpers.CommonHelpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FYP_PROJECT.Helpers.EmployeeHelpers
{
    public static class EmployeeHelper
    {
        public static List<string> GetAssignableEmployeeNames()
        {
            List<string> employeeNames = new List<string>();

            string[] excludedRoles = { "CEO", "Manager", "Supervisor" };

            using (MySqlConnection conn = DatabaseConnectionHelper.GetConnection())
            {
                try
                {
                    conn.Open();

                    // Use parameterized query or string join for roles
                    string query = "SELECT Employee_Name FROM employees WHERE Employee_Role NOT IN ( 'CEO', 'Manager', 'Supervisor', 'Head', 'Lead','Assistant Manager', 'Owner','Admin Staff','Operations Lead','Receptionist Manager','Inventory Manager','Accoutant')";
                   

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            employeeNames.Add(reader.GetString("Employee_Name"));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading employee names: " + ex.Message);
                }
            }

            return employeeNames;
        }
    }
}
