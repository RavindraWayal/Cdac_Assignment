using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    internal class Program
    {
        static void  Main(string[] args)
        {
            /* Student s=new Student (007,70,80,90);
            Student s1 = new Student(008, 90, 95, 99);
             Student s2 = new Student(009, 97, 98, 89);
             s.get_total();
             s.grt_percentage();
             Console.WriteLine(s.display());
             s1.get_total();
             s1.grt_percentage();
             Console.WriteLine(s1.display());
             s2.get_total();
             s2.grt_percentage();
             Console.WriteLine(s2.display());

             Student[] arr = new Student[3];
             arr[0]=s;
             arr[1] = s1;
             arr[2] = s2;
             Console.WriteLine("-------------------------------------");
             for(int i=0;i<arr.Length;i++)
             {
                 Console.WriteLine(arr[i].display());
             }
             Console.WriteLine("-------------------------------------");
             foreach (Student i in arr)
             {
                 Console.WriteLine(arr[i].display());
             }
            */
            /* 
             try
             {
                 Account person1 = new Account("Jay", 1, 10000.0);
                 Account person2 = new Account("ak", 2, 100.00);
                 //person1.deposite(10);
                 //Console.WriteLine(person1.display());
                 person2.deposite(10);


             }
             catch (Exception ex) 
             {
                 Console.WriteLine(ex.Message);
             }
            */
            /*
            Student1 s1 = new Student1("jay", 100, 90, 99);
            Student1 s2 = new Student1("rahul", 99, 98, 97);
            Student1 s3 = new Student1("ak", 80, 85, 90);
            s1.total_marks();
            s2.total_marks();
            s3.total_marks();
            Console.WriteLine(s1.display());
            Console.WriteLine(s2.display());
            Console.WriteLine(s3.display());
            */
            /*
            Employee e1 = new Employee(1, "jay", 30000);
            Employee e2 = new Employee(2, "rahul", 20000);
            Employee e3 = new Employee(3, "ak", 10000);
            Employee e4 = new Employee(4, "Vedant", 5000);

            e1.Calculatesal();
            e2.Calculatesal();
            e3.Calculatesal();
            e4.Calculatesal();
            Console.WriteLine(e1.display());
            Console.WriteLine(e2.display());
                
            Console.WriteLine(e3.display());
            Console.WriteLine(e4.display());
            */
            try
            {
                Account1 a1 = new Account1("Akshay", "Fagare", 20000);
                a1.deposite(2000);
                a1.withdraw(1000);
                Console.WriteLine(a1.display());
                double A=Account1.payint(a1);
                Console.WriteLine("Total income is "+A);
                a1.Balance = 1000000;
                Console.WriteLine("The balace is "+a1.Balance);
                
                Console.WriteLine("-------------------");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            try
            {
                Account1 a2 = new Account1("akki", "Fagare", 20000);
                a2.deposite(2000);
                a2.withdraw(1000);
                Console.WriteLine(a2.display());
                Console.WriteLine("-------------------");
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            
            
            //Account1 a3 = new Account1("Jayesh", "Khairnar", 200000);
            //Account1 a4 = new Account1("Rahul", "Pal", 20050);

           

            
           
            /*
            a3.deposite(2000);
            a3.withdraw(1000);
            Console.WriteLine(a3.display());
            Console.WriteLine("-------------------");
            a4.deposite(2000);
            a4.withdraw(1000);
            Console.WriteLine(a4.display());

        */
            
         
           /* Employee e1=new Employee(1, "akshay", 200000, dept.MKT);
            e1.paytax(0.18);
            e1.Calculatesal();

            Console.WriteLine(e1.display());
           */

            


        }
    }
}
