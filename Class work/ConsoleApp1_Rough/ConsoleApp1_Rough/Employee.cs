using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Rough
{
    class Employee
    {
        String First_name;
        String Last_name;
        

       /*
        public Employee(String First_name): this(First_name,"","")
        {
            this.First_name = First_name;
        }
        public Employee(String First_name, String Last_name):this(First_name , Last_name,"")
        {
            this.First_name = First_name;
            this.Last_name = Last_name;
        }*/
        public Employee(String First_name, String Last_name)
        {
           
            
                First_name = First_name;
                Last_name = Last_name;
              
            
        }
        public void display()
        {
            Console.WriteLine(First_name);
            Console.WriteLine(Last_name);
        }
    }
}
