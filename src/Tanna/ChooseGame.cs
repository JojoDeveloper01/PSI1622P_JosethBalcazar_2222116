namespace Tanna
{
    public partial class ChooseGame : Form
    {
        private Form previousForm;
        public ChooseGame(Form previousForm)
        {
            InitializeComponent();
            GlobalVar.LoadData("AllGames", GamesCreated);
            this.previousForm = previousForm;
        }

        private void Play_Click(object sender, EventArgs e)
        {
            GetSelectedGameName();
            this.Hide();
            Play play = new();
            play.ShowDialog();
            this.Show();
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
            }
        }

        private void BackChooseGame_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            GlobalVar.LoadData("AllGames", GamesCreated);
        }

        private void GetSelectedGameName()
        {
            if (GamesCreated.SelectedRows.Count > 0)
            {
                GlobalVar.SelectedGameName = GamesCreated.SelectedRows[0].Cells["Name"].Value.ToString();
            }
            else
            {
                GlobalVar.SelectedGameName = string.Empty;
            }
        }
    }
}
