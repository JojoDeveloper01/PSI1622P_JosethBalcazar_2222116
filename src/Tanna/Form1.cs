using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
namespace Tanna
{
    public partial class Form1 : Form
    {
        string dbFilePath;
        string conn;

        public Form1()
        {

            InitializeComponent();
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;

            // Build the path
            dbFilePath = Path.Combine(baseDir, @"..\..\..\Tanna.db");

            // Make sure the path is correct
            dbFilePath = Path.GetFullPath(dbFilePath);

            if (!File.Exists(dbFilePath)) // Check if the file exists
            {
                MessageBox.Show("Erro: O arquivo do banco de dados não foi encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show($"Path bd: {dbFilePath}");
            }

            // Define string to the complete path UWU
            conn = $"Data Source={dbFilePath}; Version=3";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Sing_In_Click(object sender, EventArgs e)
        {

        }

        private void Sing_Up_Click(object sender, EventArgs e)
        {
            /*
            string username = usernameRegister.Text;
            string password = passwordRegister.Text;
            string tryPassword = try_passwordRegister.Text;

            if (password != tryPassword)
            {
                MessageBox.Show("As senhas não coincidem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (InsertPlayer(username, password))
            {
                MessageBox.Show("Usuário registrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao registrar usuário!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }
        /*
        private bool InsertPlayer(string username, string password)
        {
            try
            {
                using (SQLiteConnection connection = ProgramInitializer.GetConnection())
                {
                    connection.Open();

                    string query = "INSERT INTO player (name, password) VALUES (@name, @password)";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@name", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir usuário no banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }*/

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void User_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(conn))
                {
                    cn.Open();

                    string sql = "SELECT * FROM player LIMIT 1";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, cn))
                    {
                        using (SQLiteDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                dr.Read();
                                string id_player = dr["id_player"].ToString();
                                string type = dr["type"].ToString();
                                string name = dr["name"].ToString();
                                string password = dr["password"].ToString();

                                MessageBox.Show("Nome do primeiro jogador:"+
                                    $"\n id_player: {id_player}"+
                                    $"\n type: {type}"+
                                    $"\n name: {name}"+
                                    $"\n password: {password}", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Nenhum jogador encontrado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Erro de SQLite: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}