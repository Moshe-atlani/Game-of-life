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
            int count = 0;//combien ya t il de pixel en vit autour de lui 
            char x;
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    //board[i, j] = char.Parse(Console.ReadLine());
                    x = char.Parse(Console.ReadLine());
                    board[i, j] = x;
                }
            }//sa marche pAS

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
                        if (count > 3 || count < 2)//3 eme regle
                        {
                            board[i, j] = '_';
                        }
                        else if (count == 3)//1 eme regle
                        {
                            board[i, j] = '1';
                        }
                        count = 0;
                        Console.Write(board[i,j]);
                    }
                    Console.WriteLine();
                }
            }



        }
    }
}
