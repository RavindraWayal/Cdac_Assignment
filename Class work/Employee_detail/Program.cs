using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Employee_detail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student s1 = new Student(1,"Pratham");
                Console.WriteLine (s1.display());
                s1.Name = "jayesh";
                Console.WriteLine(s1.display());
                s1.Name = "ak";
                Console.WriteLine(s1.display());
            }
            catch (Exception ex)
            {
                Console.WriteLine (ex.ToString());
            }
            


        }
    }
}
