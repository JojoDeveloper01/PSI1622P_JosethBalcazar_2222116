using System;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace Tanna
{
    public static class DBConnection
    {
        public static string dbFilePath;
        public static string connString;
        public static SQLiteConnection conn;

        static DBConnection()
        {
         /*   string baseDir = AppDomain.CurrentDomain.BaseDirectory;

            // Build the path
            dbFilePath = Path.Combine(baseDir, @"..\..\..\Tanna.db");

            // Make sure the path is correct
            dbFilePath = Path.GetFullPath(dbFilePath);

            if (!File.Exists(dbFilePath)) // Check if the file exists
            {
                MessageBox.Show("Error: The database file was not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show($"Path bd: {dbFilePath}");
                return;
            }

            // Definir a string de conexão usando o caminho completo
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

        public static SQLiteDataReader ExecuteQuery(string sql)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
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
        }*/

    }
}
