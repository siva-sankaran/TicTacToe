using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeWindowsApp
{
    public class GameBoard
    {
        private bool?[,] board = new bool?[3, 3];

        public void SetO(int row, int col)
        {
            board[row, col] = false;
        }

        public void SetX(int row, int col)
        {
            board[row, col] = true;
        }

        public bool IsWin()
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
