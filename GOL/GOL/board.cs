﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOL
{
    class Board
    {
        char[,] grid;//'1' = live---'_' = death

        public Board()
        {
            grid = new char[,]
        {
        { '1', '_', '_', '_', '_', '_', '_', '_', '1', '1',},
        { '_', '_', '1', '_', '_', '1', '_', '_', '_', '_',},
        { '_', '1', '1', '_', '1', '1', '1', '_', '_', '_',},
        { '_', '1', '_', '_', '_', '1', '_', '_', '_', '_',},
        {'_', '_', '_', '_', '_', '_', '_','1', '_','1',},
        { '_', '_', '_', '_','1', '_', '_', '_', '1', '1',},
        {'_', '1', '_', '_', '1', '_', '_', '1','_', '_',},
        { '1','1','_', '_' ,'_', '_','_', '_', '_', '_',},
        { '1', '1', '_', '_', '1', '_', '_', '1', '_', '_',},
        { '1', '1', '_', '_', '_', '_', '_', '_', '_', '1',}
        };

            //Random rnd = new Random();
            //for (int i = 0; i < b.GetLength(0); i++)
            //{
            //    for (int j = 0; j < b.GetLength(1); j++)
            //    {
            //        b[i, j] = (char)rnd.Next('1', '_'); 
            //    }
            //}//sa marche pAS ?
        }

        public char[,] GetGrid()
        {
            return grid;
        }

        public void ShowTheGrid(char[,]b)
        {
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write(b[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
