using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Triangle:TwoDshape 
    {
        public string style; // style of triangle 

        // Return area of triangle. --height, width available in the derived class due to inheritance
        public double area()
        {
            return Width * Height / 2;
        }

        // Display a triangle's style. 
        public void showStyle()
        {
            Console.WriteLine("Triangle is " + style);
        }
    }

}

