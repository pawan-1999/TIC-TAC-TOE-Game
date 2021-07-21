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
    }
}
