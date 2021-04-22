using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class TicTacToe
    {
        public static bool isValid(int[,] board)
        {
            int count0 = 0;
            int count1 = 0;

            for(int i=0;i<board.GetLength(0);i++)
            {
                for(int j=0;j<board.GetLength(1);j++)
                {
                    if (board[i,j] == 1)
                        count1++;
                    else if (board[i, j] == 0)
                        count0++;
                }
            }

            if((count0==count1) || (count1==count0+1))
            {
                if(isWinner(board,0))
                {
                    if (isWinner(board, 1))
                        return false;
                    return (count0 == count1);
                }

                if(isWinner(board,1) && count1!=count0+1)
                {
                    return false;
                }

                return true;
            }
            return false; 

        }
         
        public static bool isWinner(int[,] board,int p)
        {
            if ((board[0, 0] == p && board[0, 1] == p && board[0, 2] == p) ||
                (board[1, 0] == p && board[1, 1] == p && board[1, 2] == p) ||
                (board[2, 0] == p && board[2, 1] == p && board[2, 2] == p))
                return true;

            if ((board[0, 0] == p && board[1, 0] == p && board[2, 0] == p) ||
                (board[0, 1] == p && board[1, 1] == p && board[2, 1] == p) ||
                (board[0, 2] == p && board[1, 2] == p && board[2, 2] == p))
                return true;

            if ((board[0, 0] == p && board[1, 1] == p && board[2, 2] == p) ||
                (board[0, 2] == p && board[1, 1] == p && board[2, 0] == p))
                return true;

            return false;
        }

    }
}
