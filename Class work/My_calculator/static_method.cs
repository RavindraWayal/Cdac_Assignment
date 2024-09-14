using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_calculator
{
    public class static_method
    {
        public static void dojob()
        {
            MyCalculator m=new MyCalculator();
            m.sum(10, 20);
            m.cube(10);
        }
    }
}
