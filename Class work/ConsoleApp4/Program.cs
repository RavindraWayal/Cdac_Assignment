using My_calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program:MyCalculator
    {
        public void called()
        {
            cube(10);
            sum(10,20);

        }
        public static void Main(string[] args)
        {
            My_calculator.MyCalculator m=new My_calculator.MyCalculator ();
            m.sqr(10);
            
            Program p=new Program();
            p.cube(10); 
          
            static_method.dojob();
          
            
        }
    }
}
