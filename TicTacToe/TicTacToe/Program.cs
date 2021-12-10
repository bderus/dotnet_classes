using TicTacToe.BusinessLogic;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new TicTacToeGame();

            game.StartGame();
        }
    }
}
