using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe_Game
{
    class TicTacToeGame
    {
        char[] Board = new char[10];
        public  void gameBoard()
        {  
            for (int i = 1 ; i < 9 ; i++)
            {
                Board[i] = ' '; 
            }
        }
    }
}
