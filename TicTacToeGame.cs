using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe_Game
{
    class TicTacToeGame
    {
        public const char X = 'X';
        public const char O = 'O';

        char[] Board = new char[10];
        public  void gameBoard()
        {
           
            for (int i = 1 ; i < 9 ; i++)
            {
                Board[i] = ' '; 
            }
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
        public void showGameBoard()
        {
            Console.WriteLine(Board[1] + " " + Board[2] + " " + Board[3]);
            Console.WriteLine("-------------");
            Console.WriteLine(Board[4] + " " + Board[5] + " " + Board[6]);
            Console.WriteLine("-------------");
            Console.WriteLine(Board[7] + " " + Board[8] + " " + Board[9]);
        }
    }
}
