namespace assignment6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            PlayGame("Rock");
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            PlayGame("Paper");
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            PlayGame("Scissors");
        }
        private void PlayGame(string userChoice)
        {
            string[] options = { "Rock", "Paper", "Scissors" };
            Random random = new Random();
            int computerChoiceIndex = random.Next(0, 3);
            string computerChoice = options[computerChoiceIndex];

            DisplayResult(userChoice, computerChoice);
        }

        private void DisplayResult(string userChoice, string computerChoice)
        {
            MessageBox.Show($"Computer chose {computerChoice}.\nYou chose {userChoice}.\n\nResult: {DetermineWinner(userChoice, computerChoice)}");
        }

        private string DetermineWinner(string userChoice, string computerChoice)
        {
            if (userChoice == computerChoice)
            {
                return "It's a tie!";
            }
            else if ((userChoice == "Rock" && computerChoice == "Scissors") ||
                     (userChoice == "Paper" && computerChoice == "Rock") ||
                     (userChoice == "Scissors" && computerChoice == "Paper"))
            {
                return "You win!";
            }
            else
            {
                return "Computer wins!";
            }
        }
    }
}