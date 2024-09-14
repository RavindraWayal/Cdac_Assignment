using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_calculator
{
    public class MyCalculator
    {
        public void sqr(int x)
        {
            Console.WriteLine("The sqr is " + x * x);
        }
        protected void cube(int x)
        {
            Console.WriteLine("the cube is" + x * x * x);
        }
        internal void sum(int x, int y)
        {
            Console.WriteLine("the sum is" + (x + y));
        }
    }
    

}
