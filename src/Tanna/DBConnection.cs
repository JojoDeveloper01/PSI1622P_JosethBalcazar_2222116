using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Tanna
{
    public static class ProgramInitializer
    {
        private static string connectionString = "Data Source=tanna.db;Version=3;";
        private static SQLiteConnection connection;

        public static SQLiteConnection GetConnection()
        {
            if (connection == null)
            {
                connection = new SQLiteConnection(connectionString);
            }

            return connection;
        }

        public static void OpenConnection()
        {
            if (connection != null && connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public static void CloseConnection()
        {
            if (connection != null && connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        public static void Start()
        {
            OpenConnection();
            Application.Run(new Form1());
            CloseConnection();
        }
    }
}
