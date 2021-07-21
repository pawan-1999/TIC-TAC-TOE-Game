using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe_Game
{
    class TicTacToeGame
    {
        public const char X = 'X';
        public const char O = 'O';

        public void gameBoard()
        {
            char[] gameBoard = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' , ' '};
            Console.WriteLine(gameBoard[2]+ " " + gameBoard[3] + " " + gameBoard[4]);
            Console.WriteLine("-------------");
            Console.WriteLine(gameBoard[5] + " " + gameBoard[6] + " " + gameBoard[7]);
            Console.WriteLine("-------------");
            Console.WriteLine(gameBoard[8] + " " + gameBoard[9] + " " + gameBoard[10]);
        }

        public void abillityToInput()
        {
            Console.WriteLine("Enter you Choice from O/X :");
            char playerChoice = Convert.ToChar(Console.ReadLine());
            if (playerChoice == 'X' ) 
            {
                Console.WriteLine("Player Chose " + playerChoice);
                Console.WriteLine("Computer Chose " +O);
            }
            else if (playerChoice == 'O')
            {
                Console.WriteLine("Player Chose " + playerChoice);
                Console.WriteLine(" Computer Chose " + X);
            }
            else
            {
                Console.WriteLine("Entered invalid input  ");
            }
        }
    }
}
