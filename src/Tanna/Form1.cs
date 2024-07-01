namespace Tanna
{
    public partial class Home : Form
    {

        public Home()
        {
            InitializeComponent();
            UpdateUI();
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
            ChooseGame chooseGame = new(this);
            chooseGame.ShowDialog();
            this.Show();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_up sign_up = new(this);
            sign_up.ShowDialog();
            this.Show();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_in sign_in = new(this);
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

            // Redefinir as vari�veis globais para o estado de deslogado
            GlobalVar.Username = "";
            GlobalVar.Password = "";
            GlobalVar.ID = 0;
            GlobalVar.Type = 0;

            // Atualizar a interface do usu�rio para refletir o estado de deslogado
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
                Sign_in sign_in = new(this);
                sign_in.ShowDialog();
                this.Show();
                UpdateUI();
            }

        }

        private void Update_Click(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}