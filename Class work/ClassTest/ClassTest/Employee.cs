using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    public enum dept
    {
        MKT, ADMIN, ADV
    }
    public class Employee
    {
        int id;
        String name;
        
        double net_salary;
        
        dept d;
        static  double taxpay;
        double salary;
        static Employee()
        {
            Console.WriteLine(taxpay);
            
        }
        public Employee(int id, string name, int salary,  dept d)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.d = d;
            
        }
        public double paytax(double taxrate)
        {
            taxpay=(salary * taxrate);
           
            return taxpay;
        }
       
        public double Calculatesal()
        {
            net_salary = salary - taxpay;
            return net_salary;
        }
        public String display()
        {
            return String.Format("name={0} net_salary={1}", name, net_salary);
        }
    }
}
