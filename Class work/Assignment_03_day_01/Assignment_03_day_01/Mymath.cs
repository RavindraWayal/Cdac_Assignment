using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator

{
    internal class Mymath
    {
        public void add(int a,int b)
        {
            Console.WriteLine(a + b);
        }
        public void sub(int a,int b)
        {
            Console.WriteLine(a - b);
        }
        static void Main(string[] args)
        {
            Mymath mymath = new Mymath();
            mymath.add (1,2);   
            mymath.sub (1,2);
            Advanced_Calculator.Mymath mymath1=new Advanced_Calculator.Mymath();
            mymath1.sqr(10);
            mymath1.cube(10);
            Console.ReadLine();
        }
    }
}
namespace Advanced_Calculator
{
    public class Mymath
    {
        public void sqr(int no)
        {
            Console.WriteLine(no*no);
        }
        public void cube(int no)
        {
        Console.WriteLine(no*no*no);
        }
    }
}
