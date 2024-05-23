using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Tanna
{
    internal static class Program
    {
        public static string dbFilePath;
        public static string connString;
        public static SQLiteConnection conn;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            // Initialize the database connection
            //InitializeDatabaseConnection();

            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
        /*
        static void InitializeDatabaseConnection()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;

            // Build the path to the database
            dbFilePath = Path.Combine(baseDir, @"..\..\..\Tanna.db");

            // Ensure the path is correct
            dbFilePath = Path.GetFullPath(dbFilePath);

            if (!File.Exists(dbFilePath)) // Check if the file exists
            {
                MessageBox.Show("Error: The database file was not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show($"Path bd: {dbFilePath}");
                return;
            }

            // Define the connection string using the full path
            connString = $"Data Source={dbFilePath}; Version=3";
            conn = new SQLiteConnection(connString);

            try
            {
                conn.Open();
                MessageBox.Show("Connection to the database successfully established!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"SQLite Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal static SQLiteDataReader ExecuteQuery(string sql)
        {
            throw new NotImplementedException();
        }
        */
    }
}