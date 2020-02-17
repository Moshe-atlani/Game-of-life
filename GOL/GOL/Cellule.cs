using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOL
{
    class Cellule//jsp quoi rajouter  
    {
        char Situation;
        Board b = new Board();

        public Cellule(char Situation)
        {
            this.Situation = Situation;
        }

        public bool IsInGrid()//j ai fait cette fonction psk c t ecrie ds mon cahier mais jsp a quoi elle vas servir
        {
            for (int i = 0; i < b.GetGrid().GetLength(0); i++)
            {
                for (int j = 0; j < b.GetGrid().GetLength(1); j++)
                {
                    if (b.GetGrid()[i, j] == Situation)
                        return true;
                }
            }
            return false;
        }
    }
}
