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

            Account.Text = GlobalVar.Username;
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
            G_Username = null;
            G_Password = null;
            G_ID = 0;
            G_Type = null;
            UpdateUI();
        }
    }
}