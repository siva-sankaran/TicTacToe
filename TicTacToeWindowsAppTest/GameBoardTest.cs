using TicTacToeWindowsApp;

namespace TicTacToeWindowsAppTest
{
    public class GameBoardTest
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        public void GivenBoardWithTwoSameSignsInRow_WhenPlayer1SetsSameSign_ThenGameEndsWithPlayer1Winning(int row)
        {
            //Arrange
            GameBoard board = new();
            board.SetO(row, 0);
            board.SetO(row, 1);

            //Act
            board.SetO(row, 2);

            //Assert
            Assert.True(board.IsWin(), "Game should be in winned state");
        }
    }
}
