using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Function2.Mymath f = new Function2.Mymath();
            Function1.Mymath function = new Function1.Mymath();
            f.cube(10);
            f.sqr(10);
            function.sub(10, 5);
            function.add(10, 20);

        }
    }
}
