using System;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            InitializeDatabaseConnection();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationConfiguration.Initialize();
            Application.Run(new Home());
        }
        
        static void InitializeDatabaseConnection()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;

            // Build the path to the database
            dbFilePath = Path.Combine(baseDir, @"..\..\..\..\..\scriptsbd\Tanna.db");

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
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"SQLite Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal static SQLiteDataReader ExecuteQuery(SQLiteCommand cmd)
        {
            try
            {
                // SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                //return cmd.ExecuteReader();
                cmd.Connection = conn;
                return cmd.ExecuteReader();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"SQLite Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}