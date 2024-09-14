using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    internal class Program
    {
       
        static void Main(string[] args)
        {
            byte b1 = 6;
            byte b2 = 250;
            try
            {
                checked
                {
                    byte sum = (byte)(b1 + b2);
                    Console.WriteLine(sum);
                }
            } catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("Bye");
        }
        
    }
}
