using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
namespace Tanna
{
    public partial class Home : Form
    {

        public Home()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            Account.Visible = false;
            Logout.Visible = false;
        }

        private void UpdateUI()
        {
            bool isLoggedIn = !string.IsNullOrEmpty(GlobalVar.Username);

            SignUpButton.Visible = !isLoggedIn;
            SignInButton.Visible = !isLoggedIn;
            Account.Visible = isLoggedIn;
            Logout.Visible = isLoggedIn;

            if (isLoggedIn)
            {
                Account.Text = GlobalVar.Username;
            }
        }

        private void Play_Click(object sender, EventArgs e)
        {
            this.Hide();
            Play play = new();
            play.ShowDialog();
            this.Show();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_up sign_up = new();
            sign_up.ShowDialog();
            this.Show();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_in sign_in = new();
            sign_in.ShowDialog();
            this.Show();
            UpdateUI();
        }

        private void Account_Click(object sender, EventArgs e)
        {
            this.Hide();
            Account account = new(this);
            account.ShowDialog();
            this.Show();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            LogoutFunc();
        }

        private void LogoutFunc()
        {

            // Redefinir as variáveis globais para o estado de deslogado
            GlobalVar.Username = null;
            GlobalVar.Password = null;
            GlobalVar.ID = 0;
            GlobalVar.Type = 0;

            // Atualizar a interface do usuário para refletir o estado de deslogado
            UpdateUI();
        }

        private void CreateGame_Click(object sender, EventArgs e)
        {
            bool isLoggedIn = !string.IsNullOrEmpty(GlobalVar.Username);

            if (isLoggedIn)
            {
                this.Hide();
                CreateGame createGame = new(this);
                createGame.ShowDialog();
            }
            else
            {
                MessageBox.Show("You need sign in to create Games");
                this.Hide();
                Sign_in sign_in = new();
                sign_in.ShowDialog();
                this.Show();
                UpdateUI();
            }

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}