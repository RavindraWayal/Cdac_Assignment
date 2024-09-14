using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    delegate void Mymath(int a, int b);
    internal class Cal

    {
        internal static void add(int a,int b)
        {
            Console.WriteLine(a + b);
        }
        internal static void subtract(int a,int b) {  Console.WriteLine(a - b); }
    }
}
