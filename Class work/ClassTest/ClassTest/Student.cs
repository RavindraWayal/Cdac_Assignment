using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    internal class Student
    {
        long prn;
        int java, c, html, total;
        float percentage;

        public Student(long p, int j,int c,int html)
        {
            this.prn = p;
            this.java = j;
            this.c = c;
            this.html = html;

        }
        public void get_total()
        {
            total =java + c+html;
            
        }
        public void grt_percentage() 
        {
            percentage = ((java +c+html )/ 300.0f) * 100; 
           
        }
        public string display()
        {
            return String.Format("prn={0} total={1} percentage={2}",prn,total,percentage);
        }
    }
}
