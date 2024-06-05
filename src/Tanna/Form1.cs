using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
namespace Tanna
{
    public partial class Form1 : Form
    {
        public static string G_Username;
        public static string G_Password;
        public static int G_ID;
        public static string G_Type;


        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Sing_Up_Click(object sender, EventArgs e)
        {
            string username = usernameRegister.Text;
            string password = passwordRegister.Text;
            string tryPassword = try_passwordRegister.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(tryPassword))
            {
                MessageBox.Show("Please fill the field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!username.All(char.IsLetter))
            {
                MessageBox.Show("Username must contain only letters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password.Length < 8)
            {
                MessageBox.Show("Password must be longer than 8 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != tryPassword)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (InsertPlayer(username, password))
            {
                MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Sing_In_Click(object sender, EventArgs e)
        {
            string username = usernameLogin.Text;
            string password = passwordLogin.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (VerifyUser(username, password))
            {
                MessageBox.Show("Sign in successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Username or Password does not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string username = UsernameDel.Text;

            if (DeletePlayer(username))
            {
                MessageBox.Show($"Delete Player {username} successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Player was not removed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void User_Click(object sender, EventArgs e)
        {
            try
            {
                var sql = "SELECT * FROM player";
                var cmd = new SQLiteCommand(sql);

                using (SQLiteDataReader dr = Program.ExecuteQuery(cmd))
                {
                    if (dr != null && dr.HasRows)
                    {
                        string playerInfo = "Informações dos jogadores:\n";

                        // Itera sobre todos os registros retornados
                        while (dr.Read())
                        {
                            string id_player = dr["id_player"].ToString();
                            string type = dr["type"].ToString();
                            string name = dr["name"].ToString();
                            string password = dr["password"].ToString();

                            // Concatena as informações do jogador atual na variável playerInfo
                            playerInfo += $"\nid_player: {id_player}" +
                                          $"\ntype: {type}" +
                                          $"\nname: {name}" +
                                          $"\npassword: {password}\n";
                        }
                        MessageBox.Show(playerInfo, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No players found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"SQLite Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool VerifyUser(string username, string password)
        {
            var sql = "SELECT id_player, type FROM player WHERE name = @username AND password = @password";
            var cmd = new SQLiteCommand(sql);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            using (SQLiteDataReader dr = Program.ExecuteQuery(cmd))
            {
                if (dr != null && dr.Read())
                {
                    G_ID = Convert.ToInt32(dr["id_player"]);
                    G_Type = dr["type"].ToString();
                    G_Username = username;
                    G_Password = password;

                    MessageBox.Show($"\nID: {G_ID}" +
                                    $"\nType: {G_Type}" +
                                    $"\nName: {G_Username}" +
                                    $"\nPassword: {G_Password}");
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private bool InsertPlayer(string username, string password)
        {
            try
            {
                // Verify it the username aready exist
                var sqlCheck = "SELECT COUNT(*) FROM player WHERE name = @name";
                using (var cmdCheck = new SQLiteCommand(sqlCheck, Program.conn))
                {
                    cmdCheck.Parameters.AddWithValue("@name", username);
                    int count = Convert.ToInt32(cmdCheck.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Nome de usuário já em uso. Por favor, escolha outro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                var sqlInsert = "INSERT INTO player (name, password) VALUES (@name, @password)";
                using (var cmd = new SQLiteCommand(sqlInsert, Program.conn))
                {
                    cmd.Parameters.AddWithValue("@name", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Erro do SQLite: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool DeletePlayer(string username)
        {
            try
            {
                var sqlCheck = "SELECT COUNT(*) FROM player WHERE name != @name";
                using (var cmdCheck = new SQLiteCommand(sqlCheck, Program.conn))
                {
                    cmdCheck.Parameters.AddWithValue("@name", username);
                    int count = Convert.ToInt32(cmdCheck.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Username does not exist", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                var sql = "DELETE FROM player WHERE name=@name";

                using (var cmd = new SQLiteCommand(sql, Program.conn))
                {
                    cmd.Parameters.AddWithValue("@name", username);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Erro do SQLite: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        //private bool DeletePlayer(string username)
        //{
        //    // Cria um comando SQLite
        //    SQLiteCommand cmd = new SQLiteCommand();

        //    // Define a instrução SQL para remover o jogador
        //    cmd.CommandText = $"DELETE FROM player WHERE name=@username";

        //    // Adiciona os parâmetros ao comando
        //    cmd.Parameters.AddWithValue("@username", username);

        //    // Executa o comando e obtém o número de linhas afetadas
        //    int rowsAffected = cmd.ExecuteNonQuery();   

        //    // Fecha o comando
        //    cmd.Dispose();

        //    // Retorna verdadeiro se alguma linha foi afetada, caso contrário retorna falso
        //    return rowsAffected > 0;
        //}

    }
}