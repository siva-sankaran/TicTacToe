using TicTacToeWindowsApp;

namespace SnakeAndLadder
{
    enum Players
    {
        Player1, Player2
    }
    public partial class Form1 : Form
    {
        GameBoard board = new GameBoard();
        Players currentPlayer = Players.Player1;
        int move;
        public Form1()
        {
            InitializeComponent();
            currentPlayerLbl.Text = currentPlayer.ToString();
            move = 1;
            gameStatusLbl.Text = move.ToString();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int row = textBox.Name[7] - '0';
            int col = textBox.Name[8] - '0';
            if (e.KeyChar == 'x')
                board.SetX(row, col);
            else if (e.KeyChar == 'o')
                board.SetO(row, col);

            e.Handled = !IsValidCharacter(e.KeyChar);
            textBox.Enabled = !IsValidCharacter(e.KeyChar);
            if (board.IsWin()) 
            {
                gameStatusLbl.Text = $"{currentPlayer} is win!!";
                flowLayoutPanel1.Enabled = false;
                return;
            }
            if (IsValidCharacter(e.KeyChar))
            {
                ChangeCurrentPlayer();
                currentPlayerLbl.Text = currentPlayer.ToString();
                move++;
                gameStatusLbl.Text = move.ToString();
            }
        }

        private bool IsValidCharacter(char c)
        {
            return c == 'x' || c == 'o';
        }
        private void ChangeCurrentPlayer()
        {
            currentPlayer = (Players)(((int)currentPlayer + 1) % 2);
        }
        
    }
}
