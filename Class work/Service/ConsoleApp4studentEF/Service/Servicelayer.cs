using ConsoleApp4studentEF.Model;
using ConsoleApp4studentEF.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4studentEF.Service
{
    public  class Servicelayer
    {
        protected readonly ApplicationContext context;
        public Servicelayer() 
        {
            context = new ApplicationContext(); 
        
        }
        public void Addtion()
        {
            Student student = new Student
            {
                StudentName = "Raju",
                Gradeid = 5,
                Photo="Z"
            };
            context.Stations.Add(student);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var b=context.Stations.SingleOrDefault(a=>a.Studentid==id);
            context.Remove(b);
            context.SaveChanges();
        }

        public void update1() 
        {
            Student student = new Student
            {
                Photo="B",
                Gradeid=2,
                StudentName = "Nidhi"
            };
            context.Stations.Add(student);
            context.SaveChanges();
        }
        public void search(int id)
        {
            ApplicationContext context = new ApplicationContext();
            var a = context.Stations.Include(a=>a.Grade).First(b => b.Studentid == id);

            Console.WriteLine("{0} {1} {2} {3} ", a.Studentid, a.StudentName, a.Grade.GradeName, a.Grade.Section);
            context.SaveChanges();
        }
        public void Find_Replace(int id)
        {
            
            var st=context.Stations.Include(a=>a.Grade).First(G => G.Studentid == id);
            st.StudentName = "Tejas";
            st.Photo = "T";
            st.Grade.GradeName = "C";
            st.Grade.Section = "D";
            
            context.SaveChanges();
        }
        public void update2()
        {
            Grade grade = new Grade
            {
                GradeName = "G",
                Section="P"
            };
            context.Update(grade);
            context.SaveChanges();
        }
    }
}
