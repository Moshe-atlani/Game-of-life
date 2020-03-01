using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOL
{
    class Rules
    {
        private int neighbour;
        private Board board; 
        private char[,] b ;
       
        public Rules()
        {
            neighbour = 0;
            board = new Board();
            b = board.GetGrid();
            
        }

        public void NewStepRulse()//peut etre cree un nouvelle matrix et rentre le prochian step dedant pour ensuite le cwl
        {
            for (int row = 0; row < b.GetLength(0); row++)//ligne
            {
                for (int col = 0; col < b.GetLength(1); col++)//tour
                {
                    if (row != 0 && row != b.GetLength(0) && col != 0 && col != b.GetLength(1))//senser vairifier si on ne sort pas de la matrix a cause de + ou - j ou i
                    { 
                        if (b[row, col + 1] == '1')
                            neighbour++;
                        
                        //[ ][ ][ ]
                        //[ ][1][?]
                        //[ ][ ][ ]
                        if (b[row, col - 1] == '1')//PB LA
                            neighbour++;
                        //[ ][ ][ ]
                        //[?][1][ ]
                        //[ ][ ][ ]
                        if (b[row + 1, col] == '1')
                            neighbour++;
                        //[ ][?][ ]
                        //[ ][1][ ]
                        //[ ][ ][ ]
                        if (b[row - 1, col] == '1')
                            neighbour++;
                        //[ ][ ][ ]
                        //[ ][1][ ]
                        //[ ][?][ ]
                        if (b[row - 1, col - 1] == '1')
                            neighbour++;
                        //[?][ ][ ]
                        //[ ][1][ ]
                        //[ ][ ][ ]
                        if (b[row - 1, col + 1] == '1')
                            neighbour++;
                        //[ ][ ][?]
                        //[ ][1][ ]
                        //[ ][ ][ ]
                        if (b[row + 1, col - 1] == '1')
                            neighbour++;
                        //[ ][ ][ ]
                        //[ ][1][ ]
                        //[?][ ][ ]
                        if (b[row + 1, col + 1] == '1')
                            neighbour++;
                        //[ ][ ][ ]
                        //[ ][1][ ]
                        //[ ][ ][?]
                    }
                    else
                    {
                        if(row == 0 && col == b.GetLength(0))//parfait
                            //row 0[ ][ ][?]
                            //row 1[ ][v][ ]
                            //row 2[ ][ ][ ]
                        {
                            if (b[row, col - 1] == '1')
                                neighbour++;
                            if (b[row + 1, col - 1] == '1')
                                neighbour++;
                            if (b[row + 1, col] == '1')
                                neighbour++;
                        }

                        if(row == 0 && col == 0)//parfait
                        //row 0[?][ ][ ]
                        //row 1[ ][v][ ]
                        //row 2[ ][ ][ ]
                        {
                            if (b[row, col + 1] == '1')
                                neighbour++;
                            if (b[row + 1, col + 1] == '1')
                                neighbour++;
                            if (b[row + 1, col] == '1')
                                neighbour++;
                        }

                        if(row == b.GetLength(1) && col == 0)//parfait
                        //row 0[ ][ ][ ]
                        //row 1[ ][v][ ]
                        //row 2[?][ ][ ]
                        {
                            if (b[row - 1, col] == '1')
                                neighbour++;
                            if (b[row - 1, col + 1] == '1')
                                neighbour++;
                            if (b[row, col + 1] == '1')
                                neighbour++;
                        }

                        if(row == b.GetLength(1) && col == b.GetLength(0))//parfait
                        //row 0[ ][ ][ ]
                        //row 1[ ][v][ ]
                        //row 2[ ][ ][?]
                        {
                            if (b[row, col - 1] == '1')
                                neighbour++;
                            if (b[row - 1, col - 1] == '1')
                                neighbour++;
                            if (b[row - 1, col] == '1')
                                neighbour++;

                        }
                        
                        if(col != 0 && col != b.GetLength(0) && row == b.GetLength(1))//bon
                        //row 0[ ][ ][ ][ ]
                        //row 1[ ][ ][ ][ ]
                        //row 2[ ][ ][ ][ ] 
                        //row 3[ ][?][?][ ]
                        {
                            if (b[row, col + 1] == '1')
                                neighbour++;
                            //[ ][ ][ ]
                            //[ ][1][?]
                            //[ ][ ][ ]
                            if (b[row, col - 1] == '1')//PB LA
                                neighbour++;
                            //[ ][ ][ ]
                            //[?][1][ ]
                            //[ ][ ][ ]
                            if (b[row + 1, col] == '1')
                                neighbour++;
                            //[ ][?][ ]
                            //[ ][1][ ]
                            //[ ][ ][ ]
                            if (b[row - 1, col - 1] == '1')
                                neighbour++;
                            //[?][ ][ ]
                            //[ ][1][ ]
                            //[ ][ ][ ]
                            if (b[row - 1, col + 1] == '1')
                                neighbour++;
                            //[ ][ ][?]
                            //[ ][1][ ]
                            //[ ][ ][ ]
                        }

                        if (col != 0 && col  != b.GetLength(0) && row == 0)//Gros pb ici!!!!!
                        //row 0[ ][?][?][ ]
                        //row 1[ ][ ][ ][ ]
                        //row 2[ ][ ][ ][ ] 
                        //row 3[ ][ ][ ][ ]
                        {
                            if (b[row, col + 1 ] == '1')//la nouveau pb
                                neighbour++;
                            //[ ][ ][ ]
                            //[ ][1][?]
                            //[ ][ ][ ]
                            if (b[row, col - 1] == '1')//PB LA
                                neighbour++;
                            //[ ][ ][ ]
                            //[?][1][ ]
                            //[ ][ ][ ]
                            if (b[row + 1, col] == '1')
                                neighbour++;
                            //[ ][ ][ ]
                            //[ ][1][ ]
                            //[ ][?][ ]
                            if (b[row + 1, col - 1] == '1')
                                neighbour++;
                            //[ ][ ][ ]
                            //[ ][1][ ]
                            //[?][ ][ ]
                            if (b[row + 1, col + 1] == '1')
                                neighbour++;
                            //[ ][ ][ ]
                            //[ ][1][ ]
                            //[ ][ ][?]
                        }

                        if(row != 0 && row != b.GetLength(0) && col == b.GetLength(1))//bon 
                        //row 0[ ][ ][ ][ ]
                        //row 1[ ][ ][ ][?]
                        //row 2[ ][ ][ ][?] 
                        //row 3[ ][ ][ ][ ]
                        {
                            if (b[row, col - 1] == '1')//PB LA
                                neighbour++;
                            //[ ][ ][ ]
                            //[?][1][ ]
                            //[ ][ ][ ]
                            if (b[row + 1, col] == '1')
                                neighbour++;
                            //[ ][?][ ]
                            //[ ][1][ ]
                            //[ ][ ][ ]
                            if (b[row - 1, col] == '1')
                                neighbour++;
                            //[ ][ ][ ]
                            //[ ][1][ ]
                            //[ ][?][ ]
                            if (b[row - 1, col - 1] == '1')
                                neighbour++;
                            //[?][ ][ ]
                            //[ ][1][ ]
                            //[ ][ ][ ]
                            if (b[row + 1, col - 1] == '1')
                                neighbour++;
                            //[ ][ ][ ]
                            //[ ][1][ ]
                            //[?][ ][ ]

                        }

                        if (row != 0 && row != b.GetLength(0) && col == 0)//bon
                        //row 0[ ][ ][ ][ ]
                        //row 1[?][ ][ ][ ]
                        //row 2[?][ ][ ][ ] 
                        //row 3[ ][ ][ ][ ]
                        {
                            if (b[row + 1, col] == '1')
                                neighbour++;
                            //[ ][?][ ]
                            //[ ][1][ ]
                            //[ ][ ][ ]
                            if (b[row - 1, col] == '1')
                                neighbour++;
                            //[ ][ ][ ]
                            //[ ][1][ ]
                            //[ ][?][ ]
                            if (b[row + 1, col + 1] == '1')
                                neighbour++;
                            //[ ][ ][ ]
                            //[ ][1][ ]
                            //[ ][ ][?]
                            if (b[row - 1, col + 1] == '1')
                                neighbour++;
                            //[ ][ ][?]
                            //[ ][1][ ]
                            //[ ][ ][ ]
                            if (b[row, col + 1] == '1')
                                neighbour++;
                            //[ ][ ][ ]
                            //[ ][1][?]
                            //[ ][ ][ ]
                        }

                    }

                    if (neighbour > 3 || neighbour < 2)//3 eme regle
                    {
                        b[row, col] = '_';
                        board.ChangeTheCell(row, col, '_');
                    }
                    else if (neighbour == 3)//1 eme regle
                    {
                        b[row, col] = '1';
                        board.ChangeTheCell(row, col, '1');
                    }
                    neighbour = 0;

                }
            }
            //return b;
            board.ChangeTheGrid(b);
        }


    }
}
