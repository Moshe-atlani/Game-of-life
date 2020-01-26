using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOL
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] board = new char[8, 8];//'1' = live---'_' = death
            int count = 0;//combien ya t il de pixel en vit autour de lui ( si il est en vit ) 
            for (int i = 0; i < board.GetLength(0); i++)//ligne
            {
                for (int j = 0; j < board.GetLength(1); j++)//tour
                {
                    if (board[i, j] == 1)//dison [0,0]
                    {
                        if (board[i, j + 1] == '1')
                            count++;
                        //[ ][ ][ ]
                        //[ ][1][?]
                        //[ ][ ][ ]
                        if (board[i, j - 1] == '1')
                            count++;
                        //[ ][ ][ ]
                        //[?][1][ ]
                        //[ ][ ][ ]
                        if (board[i + 1, j] == '1')
                            count++;
                        //[ ][?][ ]
                        //[ ][1][ ]
                        //[ ][ ][ ]
                        if (board[i - 1, j] == '1')
                            count++;
                        //[ ][ ][ ]
                        //[ ][1][ ]
                        //[ ][?][ ]
                        if (board[i - 1, j - 1] == '1')
                            count++;
                        //[?][ ][ ]
                        //[ ][1][ ]
                        //[ ][ ][ ]
                        if (board[i - 1, j + 1] == '1')
                            count++;
                        //[ ][ ][?]
                        //[ ][1][ ]
                        //[ ][ ][ ]
                        if (board[i + 1, j - 1] == '1')
                            count++;
                        //[ ][ ][ ]
                        //[ ][1][ ]
                        //[?][ ][ ]
                        if (board[i + 1, j + 1] == '1')
                            count++;
                        //[ ][ ][ ]
                        //[ ][1][ ]
                        //[ ][ ][?]
                        if (count > 3 || count < 2)
                            board[i, j] = '_';


                    }
                }
            }

        }
    }
}
