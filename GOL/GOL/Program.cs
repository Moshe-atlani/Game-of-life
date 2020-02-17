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
            Board bo = new Board();
            Rules ru = new Rules();

            bo.ShowTheGrid();
            ru.NewStepRulse();//cencer changer le  coeur du grid(dans le Board)--->donc changer le print de ShowTheGrid


        }
    }
}
