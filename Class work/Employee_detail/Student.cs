using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Employee_detail
{
    internal class Student
    {
        int id;
        String name;

        public Student(int id,String name) 
        {
            Id = id;
            Name = name;
        }
        public String Name
        { 
            get 
            { 
                return name; 
            }
            set
            {
                if (value.Length > 3 && value.Length < 15)
                {
                    name = value;
                }
                else
                {
                    throw new Exception("The invalid length of name");
                }
            }        
        }
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value; 
            }
        }
        public String display()
        {
            return String.Format("name={0} id={1}", name, id);
        }


    }
}
