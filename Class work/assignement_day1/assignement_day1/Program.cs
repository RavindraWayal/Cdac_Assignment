using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignement_day1
{
    internal class Program
    {
        public float sqr(float no)
        {
            return no* no;

        }
        public double product(int a, int b)
        {
            return a * b;
        }
        public int sum(int a, int b)
        {
            return (int)(a + b);
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            float square=program.sqr(15.2f);
            Console.WriteLine(square);
            double pro = program.product(10, 40);
            Console.WriteLine(pro);
            int summ = program.sum(20, 10);
            Console.WriteLine(summ);
            Console.ReadLine();
        }
    }
}
