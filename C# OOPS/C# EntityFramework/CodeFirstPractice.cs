using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            CollegeDBContext context = new CollegeDBContext();
            var stu = context.Students;
            var s1 = stu.Add(new Student() {ID=1,Stu_Name="Praveen",Num="9553333820",Dep_ID=2 });
            var s2 = stu.Add(new Student() { ID = 2, Stu_Name = "Kowshik", Num = "9789803896", Dep_ID = 2 });
            var s3 = stu.Add(new Student() { ID = 3, Stu_Name = "Aravind", Num = "7799081806", Dep_ID = 1 });

            var dep = context.Departments;
            var d1 = dep.Add(new Department() { id = 1, Dep_Name = "EEE" });
            var d2 = dep.Add(new Department() { id = 2, Dep_Name = "ECE" });

            context.SaveChanges();

        }
   
    }

    public class CollegeDBContext : DbContext
    {
        public CollegeDBContext() : base("name=CollegeDBContext")
        { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
    }

    public class Student
    {
        public int ID { get; set; }
        public string Stu_Name { get; set; }
        public string Num { get; set; }
        public int Dep_ID { get; set; }
    }

    public class Department
    {
        public int id { get; set; }
        public string Dep_Name { get; set; }
    }
}
