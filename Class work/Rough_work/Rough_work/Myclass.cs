using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rough_work
{
    public class Myclass
    {
        static int get_id;
        String name;
        int id;
        double salary;
        int mark;

       public Myclass(String name,double d,int m)
        {
            this.name = name;
            this.id = ++get_id;
            this.salary = d;
            this.mark = m;
        }
        public String Name
        { get 
            {
                return name;
            }
            set
            {
                name=value;
            }
        }
        
        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary=value;
            }
        }
        public int Mark
        {
            get
            {
                return mark;
            }
            set
            {
                mark=value;
            }
        }

        public void display()
        {
            Console.WriteLine("name={0} id={1} salary={2} mark={3}",name ,id,salary,mark);
        }

    }
}