using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function1
{
    public class Mymath
    {
        public void add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public void sub(in int x, in int y) 
        {
            Console.WriteLine(x - y);
        }
    }
}
