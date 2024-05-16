using System.Data.SQLite;
using System.Windows.Forms;
namespace Tanna
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Sing_In_Click(object sender, EventArgs e)
        {

        }

        private void Sing_Up_Click(object sender, EventArgs e)
        {
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
        }

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
        }

    }
}