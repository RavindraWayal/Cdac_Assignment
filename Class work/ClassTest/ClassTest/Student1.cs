using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    internal class Student1
    {
        String name;
        int maths, science, eng;
        int marks;

        static Student1()
        {
            Console.WriteLine("Vita collage student");
        }
        public Student1(string name, int maths, int science, int eng)
        {
            this.name = name;
            this.maths = maths;
            this.science = science;
            this.eng = eng;
            
        }
        public void total_marks()
        {
            marks=maths+science+eng;
        }

        public String display()
        {
            return String.Format("name={0} marks={1}",name,marks);
        }
    }
}
