using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
namespace Tanna
{
    public partial class Home : Form
    {
        public static string G_Username;
        public static string G_Password;
        public static int G_ID;
        public static string G_Type;

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
            Account account = new();
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
    }
}