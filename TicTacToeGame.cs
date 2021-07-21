using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe_Game
{
    class TicTacToeGame
    {
        public void gameBoard()
        {
            char[] gameBoard = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' , ' '};
            Console.WriteLine(gameBoard[2]+ " " + gameBoard[3] + " " + gameBoard[4]);
            Console.WriteLine("-------------");
            Console.WriteLine(gameBoard[5] + " " + gameBoard[6] + " " + gameBoard[7]);
            Console.WriteLine("-------------");
            Console.WriteLine(gameBoard[8] + " " + gameBoard[9] + " " + gameBoard[10]);
        }
    }
}
