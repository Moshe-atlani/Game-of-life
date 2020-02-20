using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOL
{
    class Rules
    {
        int neighbour = 0;//combien de pixel vit autour de lui 
        Board board = new Board();
        char[,] b ;
       
        public Rules()
        {
            b = board.GetGrid();
        }

        public void NewStepRulse()//peut etre cree un nouvelle matrix et rentre le prochian step dedant pour ensuite le cwl
        {
            for (int i = 0; i < b.GetLength(0); i++)//ligne
            {
                for (int j = 0; j < b.GetLength(1); j++)//tour
                {
                    if (i != 0 && i != b.GetLength(0) && j != 0 && j != b.GetLength(1))//senser vairifier si on ne sort pas de la matrix a cause de + ou - j ou i
                    { 
                        //j ai ce if psk j avai une pb (Index was outside the bounds of the array.)
                                                                                       //[ ][ ][ ]
                                                                                       //[ ][?][ ]
                                                                                       //[ ][ ][ ]
                    
                        if (b[i, j + 1] == '1')
                            neighbour++;
                        //[ ][ ][ ]
                        //[ ][1][?]
                        //[ ][ ][ ]
                        if (b[i, j - 1] == '1')//PB LA
                            neighbour++;
                        //[ ][ ][ ]
                        //[?][1][ ]
                        //[ ][ ][ ]
                        if (b[i + 1, j] == '1')
                            neighbour++;
                        //[ ][?][ ]
                        //[ ][1][ ]
                        //[ ][ ][ ]
                        if (b[i - 1, j] == '1')
                            neighbour++;
                        //[ ][ ][ ]
                        //[ ][1][ ]
                        //[ ][?][ ]
                        if (b[i - 1, j - 1] == '1')
                            neighbour++;
                        //[?][ ][ ]
                        //[ ][1][ ]
                        //[ ][ ][ ]
                        if (b[i - 1, j + 1] == '1')
                            neighbour++;
                        //[ ][ ][?]
                        //[ ][1][ ]
                        //[ ][ ][ ]
                        if (b[i + 1, j - 1] == '1')
                            neighbour++;
                        //[ ][ ][ ]
                        //[ ][1][ ]
                        //[?][ ][ ]
                        if (b[i + 1, j + 1] == '1')
                            neighbour++;
                        //[ ][ ][ ]
                        //[ ][1][ ]
                        //[ ][ ][?]
                    }
                    else
                    {
                        if(i == 0 && j == b.GetLength(0))
                        {
                            if (b[i, j - 1] == '1')
                                neighbour++;
                            if (b[i + 1, j - 1] == '1')
                                neighbour++;
                            if (b[i + 1, j] == '1')
                                neighbour++;
                        }

                        if(i == 0 && j == 0)
                        {
                            if (b[i, j + 1] == '1')
                                neighbour++;
                            if (b[i + 1, j + 1] == '1')
                                neighbour++;
                            if (b[i + 1, j] == '1')
                                neighbour++;
                        }

                        if(i == b.GetLength(1) && j == 0)
                        {
                            if (b[i - 1, j] == '1')
                                neighbour++;
                            if (b[i - 1, j + 1] == '1')
                                neighbour++;
                            if (b[i, j + 1] == '1')
                                neighbour++;
                        }

                        if(i == b.GetLength(1) && j == b.GetLength(0))
                        {
                            if (b[i, j - 1] == '1')
                                neighbour++;
                            if (b[i - 1, j - 1] == '1')
                                neighbour++;
                            if (b[i - 1, j] == '1')
                                neighbour++;

                        }

                        if(j - 1 != 0 && j + 1 != b.GetLength(0) && i == b.GetLength(1))
                        {
                            if (b[i, j + 1] == '1')
                                neighbour++;
                            //[ ][ ][ ]
                            //[ ][1][?]
                            //[ ][ ][ ]
                            if (b[i, j - 1] == '1')//PB LA
                                neighbour++;
                            //[ ][ ][ ]
                            //[?][1][ ]
                            //[ ][ ][ ]
                            if (b[i + 1, j] == '1')
                                neighbour++;
                            //[ ][?][ ]
                            //[ ][1][ ]
                            //[ ][ ][ ]
                            if (b[i - 1, j - 1] == '1')
                                neighbour++;
                            //[?][ ][ ]
                            //[ ][1][ ]
                            //[ ][ ][ ]
                            if (b[i - 1, j + 1] == '1')
                                neighbour++;
                            //[ ][ ][?]
                            //[ ][1][ ]
                            //[ ][ ][ ]
                        }

                        if (j - 1 != 0 && j + 1 != b.GetLength(0) && i == 0)
                        {
                            if (b[i, j + 1] == '1')
                                neighbour++;
                            //[ ][ ][ ]
                            //[ ][1][?]
                            //[ ][ ][ ]
                            if (b[i, j - 1] == '1')//PB LA
                                neighbour++;
                            //[ ][ ][ ]
                            //[?][1][ ]
                            //[ ][ ][ ]
                            if (b[i - 1, j] == '1')
                                neighbour++;
                            //[ ][ ][ ]
                            //[ ][1][ ]
                            //[ ][?][ ]
                            if (b[i + 1, j - 1] == '1')
                                neighbour++;
                            //[ ][ ][ ]
                            //[ ][1][ ]
                            //[?][ ][ ]
                            if (b[i + 1, j + 1] == '1')
                                neighbour++;
                            //[ ][ ][ ]
                            //[ ][1][ ]
                            //[ ][ ][?]
                        }

                        if(i - 1 != 0 && i + 1 != b.GetLength(0) && j == b.GetLength(1))
                        {
                            if (b[i, j - 1] == '1')//PB LA
                                neighbour++;
                            //[ ][ ][ ]
                            //[?][1][ ]
                            //[ ][ ][ ]
                            if (b[i + 1, j] == '1')
                                neighbour++;
                            //[ ][?][ ]
                            //[ ][1][ ]
                            //[ ][ ][ ]
                            if (b[i - 1, j] == '1')
                                neighbour++;
                            //[ ][ ][ ]
                            //[ ][1][ ]
                            //[ ][?][ ]
                            if (b[i - 1, j - 1] == '1')
                                neighbour++;
                            //[?][ ][ ]
                            //[ ][1][ ]
                            //[ ][ ][ ]
                            if (b[i + 1, j - 1] == '1')
                                neighbour++;
                            //[ ][ ][ ]
                            //[ ][1][ ]
                            //[?][ ][ ]

                        }

                        if (i - 1 != 0 && i + 1 != b.GetLength(0) && j == 0)
                        {
                            if (b[i + 1, j] == '1')
                                neighbour++;
                            //[ ][?][ ]
                            //[ ][1][ ]
                            //[ ][ ][ ]
                            if (b[i - 1, j] == '1')
                                neighbour++;
                            //[ ][ ][ ]
                            //[ ][1][ ]
                            //[ ][?][ ]
                            if (b[i + 1, j + 1] == '1')
                                neighbour++;
                            //[ ][ ][ ]
                            //[ ][1][ ]
                            //[ ][ ][?]
                            if (b[i - 1, j + 1] == '1')
                                neighbour++;
                            //[ ][ ][?]
                            //[ ][1][ ]
                            //[ ][ ][ ]
                            if (b[i, j + 1] == '1')
                                neighbour++;
                            //[ ][ ][ ]
                            //[ ][1][?]
                            //[ ][ ][ ]
                        }

                    }

                    if (neighbour > 3 || neighbour < 2)//3 eme regle
                    {
                        b[i, j] = '_';
                        board.ChangeTheCell(i, j, '_');
                    }
                    else if (neighbour == 3)//1 eme regle
                    {
                        b[i, j] = '1';
                        board.ChangeTheCell(i, j, '1');
                    }
                    neighbour = 0;

                }
            }
            //return b;
            board.ChangeTheGrid(b);
        }


    }
}
