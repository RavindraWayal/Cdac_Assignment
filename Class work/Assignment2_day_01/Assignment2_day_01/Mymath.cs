using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_day_01
{
    internal static class Mymath
    {
        public static double cube(double no)
        {
            return no*no*no;
        }
        public static int add(int a, int b)
        {
            return a + b;
        }
        public static int fact(int no)
        {
            int i = 1;
            int fact = 1;
            while (i <= no) 
            {
                fact=fact*i;
                i++;

            }
            return fact;
        }
        static void Main(string[] args)
        {
            double cu=Mymath.cube(3);
            Console.WriteLine(cu);
            int sum = Mymath.add(10, 30);
            Console.WriteLine(sum);
            int factorial=Mymath.fact(5);
            Console.WriteLine(factorial);
            Console.ReadLine();
        }
    }
}
