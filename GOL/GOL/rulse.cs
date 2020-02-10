﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOL
{
    class Rulse
    {
        int neighbour = 0;//combien de pixel vit autour de lui 

        public char[,] NewStepRulse(char[,] b)//peut etre cree un nouvelle matrix et rentre le prochian step dedant pour ensuite le cwl
        {
            for (int i = 0; i < b.GetLength(0); i++)//ligne
            {
                for (int j = 0; j < b.GetLength(1); j++)//tour
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
                        if (neighbour > 3 || neighbour < 2)//3 eme regle
                        {
                            b[i, j] = '_';
                        }
                        else if (neighbour == 3)//1 eme regle
                        {
                            b[i, j] = '1';
                        }
                        neighbour = 0;
        
                }
            }
            return b;
        }
    }
}