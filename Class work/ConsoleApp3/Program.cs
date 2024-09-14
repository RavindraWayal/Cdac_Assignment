using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle() { Width  = 4.0, Height = 4.0, style = "isosceles" };
            Triangle t2 = new Triangle() { Width = 8.0, Height = 12.0, style = "right" };
            Console.WriteLine("Info for t1: ");
            t1.showStyle();
            t1.showDim();
            Console.WriteLine("Area is " + t1.area());
            Console.WriteLine("Info for t2: ");
            t2.showStyle();
            t2.showDim();
            Console.WriteLine("Area is " + t2.area());
        }

    }
}

