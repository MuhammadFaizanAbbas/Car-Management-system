using MySql.Data.MySqlClient;

namespace FYP_PROJECT.Helpers.CommonHelpers
{
    public static class DatabaseConnectionHelper
    {
        private static readonly string connectionString = "server=localhost;uid=root;pwd=;database=pristineshine;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
