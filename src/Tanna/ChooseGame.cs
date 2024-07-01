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

            if (string.IsNullOrEmpty(GlobalVar.SelectedGameName))
            {
                MessageBox.Show("No game selected. Please select a game from the list.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Sai do método se nenhum jogo foi selecionado
            }

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
                Sign_in sign_in = new(this);
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
