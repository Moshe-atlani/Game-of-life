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
            Rulse ru = new Rulse();
            //Console.WriteLine(bo.GetGrid()[0,1]);
            bo.ShowTheGrid(bo.GetGrid());
            Console.WriteLine("lechangement c  maintenen");
            bo.ShowTheGrid(ru.NewStepRulse(bo.GetGrid()));

        }
    }
}
