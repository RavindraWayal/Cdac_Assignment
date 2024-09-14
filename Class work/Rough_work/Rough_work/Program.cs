using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rough_work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Myclass m1 = new Myclass("Aditya", 20000, 98);
            Myclass m2 = new Myclass("Avdhut", 30000, 99);
            Myclass m3 = new Myclass("Mahesh", 50000, 95);
            Myclass m4 = new Myclass("raj", 234000, 100);

            m1.display();
            m2.display();
                
            m3.display();
            m4.display();

            m1.Mark = 95;
            m1.display();


        }
    }
}
