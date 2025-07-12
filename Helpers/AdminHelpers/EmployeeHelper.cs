using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using FYP_PROJECT.Helpers.CommonHelpers;

namespace FYP_PROJECT.Helpers.AdminHelpers
{
    public static class EmployeeHelper
    {
        public static Dictionary<string, int> GetEmployeeCountByRole()
        {
            var roleCounts = new Dictionary<string, int>();

            using (var conn = DatabaseConnectionHelper.GetConnection())
            using (var cmd = new MySqlCommand(@"
                SELECT Employee_Role, COUNT(*) AS Total
                FROM employees
                GROUP BY Employee_Role", conn))
            {
                conn.Open();
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        string role = rdr.GetString("Employee_Role");
                        int count = rdr.IsDBNull(rdr.GetOrdinal("Total")) ? 0 : rdr.GetInt32("Total");
                        roleCounts[role] = count;
                    }
                }
            }

            return roleCounts;
        }
    }
}
