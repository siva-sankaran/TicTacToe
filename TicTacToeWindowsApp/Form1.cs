namespace SnakeAndLadder
{
    enum Players
    {
        Player1, Player2
    }
    public partial class Form1 : Form
    {
        bool?[,] board = new bool?[3,3];
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
            board[row, col] = e.KeyChar == 'x' ? true : e.KeyChar == 'o' ? false : null;
            e.Handled = !IsValidCharacter(e.KeyChar);
            textBox.Enabled = !IsValidCharacter(e.KeyChar);
            if (IsWin(board)) 
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
        private bool IsWin(bool?[,] board)
        {
            bool IsFirstRowMatched = (board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2])
                && board[0, 0] != null
                && board[0, 1] != null
                && board[0, 2] != null;

            bool IsSecondRowMatched = (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2])
                && board[1, 0] != null
                && board[1, 1] != null
                && board[1, 2] != null;

            bool IsThirdRowMatched = (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2])
                && board[2, 0] != null
                && board[2, 1] != null
                && board[2, 2] != null;

            bool IsFirstColumnMatched = (board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0])
                && board[0, 0] != null
                && board[1, 0] != null
                && board[2, 0] != null;

            bool IsSecondColumnMatched = (board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1])
                && board[0, 1] != null
                && board[1, 1] != null
                && board[2, 1] != null;

            bool IsThirdColumnMatched = (board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2])
                && board[0, 2] != null
                && board[1, 2] != null
                && board[2, 2] != null;

            bool IsTopLeftStartDiagonalMatched = (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                && board[0, 0] != null
                && board[1, 1] != null
                && board[2, 2] != null;

            bool IsBottomLeftStartDiagonalMatched = (board[2, 0] == board[1, 1] && board[1, 1] == board[0, 2])
                && board[2, 0] != null
                && board[1, 1] != null
                && board[0, 2] != null;

            return IsFirstRowMatched ||
                IsSecondRowMatched ||
                IsThirdRowMatched ||
                IsFirstColumnMatched ||
                IsSecondColumnMatched ||
                IsThirdColumnMatched ||
                IsTopLeftStartDiagonalMatched ||
                IsBottomLeftStartDiagonalMatched;
        }
    }
}
