using System;
using System.Collections.Generic;
namespace TicTacToe
{
    class Program
    {
           
        public static void Main(string[] args)
        {
            //TODO - Add possibility to select starting player symbol and pass it to constructor as variable
            SelectPlayer();

        }
        static void SelectPlayer()
        {
            Console.WriteLine("Wybierz gracza: X lub 0: ");
            var selectPlayer = Console.ReadLine();
            
            TicTacToeGame ticTacToeGame = new TicTacToeGame(selectPlayer);
            

            switch (selectPlayer)
            {
                case "X":
                    ticTacToeGame.Play();
                    break;

                case "0":
                    ticTacToeGame.Play();
                    break;
                default:
                    Console.WriteLine("Nie ma takiego gracza ");
                    SelectPlayer();
                    break;
                
            }
            
        }
    }
}