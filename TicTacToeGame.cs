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
            Random random = new Random();
            int compChoice = random.Next(0, 2);
            Console.WriteLine("Enter you Choice from O/X :");
            char playerChoice = Convert.ToChar(Console.ReadLine());
            if ((playerChoice == 'X' || playerChoice =='O') 
            {
                Console.WriteLine("Player Chose " + playerChoice);
            }
            else
            {
                Console.WriteLine("Entered invalid input  ");
            }
            
            switch (compChoice)
            {
                case 0:
                    Console.WriteLine("Comp have choose " +O) ;
                    break;
                case 1:
                    Console.WriteLine("Comp have choose " +X);
                    break;
            }

        }
    }
}

