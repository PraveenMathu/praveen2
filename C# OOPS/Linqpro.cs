using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqpro
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] employee = new string[5] { "Kowshik", "vPraveen", "Mohan", "Vimal", "Gokul" };

            var knownemp = from emp in employee where emp.Contains("o") select emp;

            foreach (string emp in knownemp)
                Console.WriteLine(emp);

            Console.WriteLine("***************************\n");

            List<string> fruits = new List<string> { "Apple", "Orange", "Grapes", "Pineapple",
                                                     "Banana", "Watermelon" };

            var fruwithp = from fr in fruits where fr.Contains("p") select fr;

            foreach (var f in fruwithp)
                Console.WriteLine("Fruit with letter p : {0}", f);
            Console.WriteLine("***************************\n");


            var largefruit = from fru in fruits where fru.Length > 6 select fru;

            foreach (var f in largefruit)
                Console.WriteLine("Large name fruit : {0}", f);
            Console.WriteLine("***************************\n");

            var smallfruit = fruits.Where(fru => fru.Length <= 6);

            foreach (var f in smallfruit)
                Console.WriteLine("Large name fruit : {0}", f);
            Console.WriteLine("***************************\n");

            int[] marks = new int[5] { 95, 85, 94, 75, 88 };

            var higmark = from hm in marks where hm > 90 select hm;

            foreach (var f in higmark)
                Console.WriteLine("Marks Grater then 90 : {0}", f);
            Console.WriteLine("***************************\n");


            var marksinorder = from mo in marks orderby mo descending select mo;

            foreach (var f in marksinorder)
                Console.WriteLine("Low to High : {0}", f);
            Console.WriteLine("***************************\n");

            var MIO = marks.OrderBy(m => m);
            foreach (var f in MIO)
                Console.WriteLine("High to Low : {0}", f);
            Console.WriteLine("***************************\n");




            //List<Employee> empy = new List<Employee>
            //{
            //    new Employee { Emp_Id = 101, Emp_Name = "Gokul" },
            //    new Employee{ Emp_Id = 102, Emp_Name = "Mohan" },
            //    new Employee{ Emp_Id = 103, Emp_Name = "Kowshik" }
            //};

            List<Employee> empy = new List<Employee>();
            empy.Add(new Employee() { Emp_Id = 101, Emp_Name = "Gokul" });
            empy.Add(new Employee() { Emp_Id = 102, Emp_Name = "Mohan" });
            empy.Add(new Employee() { Emp_Id = 103, Emp_Name = "Kowshik" });

            //foreach (var f in empy)
            //    Console.WriteLine("Id -> {0}   Name -> {1}", f.Emp_Id,f.Emp_Name);
            //Console.WriteLine("***************************\n");

            var Id = from em in empy where em.Emp_Name.Contains("o") select em;

            foreach (var f in Id)
                Console.WriteLine("Name : {0} \n Id : {1} ", f.Emp_Name,f.Emp_Id);
            Console.WriteLine("***************************\n");


            List<Product> pr = new List<Product>();
            pr.Add(new Product() { Pro_Id = 111, Pro_Name = "Praveen milk" });
            pr.Add(new Product() { Pro_Id = 222, Pro_Name = "Chinnaya milk" });
            pr.Add(new Product() { Pro_Id = 333, Pro_Name = "Mathu milk" });

            var res = from p in pr where p.Pro_Name.Length > 10 select p;

            foreach (var p in res)
                Console.WriteLine("Id : {0}  Name ; {1}", p.Pro_Id, p.Pro_Name);
            Console.WriteLine("***************************\n");


            List<Teacher> Tech = new List<Teacher>
            {
                new Teacher { Tech_Id = 101, Tech_Name = "Gokul", Tech_City="CHN" },
                new Teacher{ Tech_Id = 102, Tech_Name = "Mohan", Tech_City="CHN" },
                new Teacher{ Tech_Id = 103, Tech_Name = "Kowshik", Tech_City="BLR" }
            };

            List<Student> Std = new List<Student>
            {
                new Student { Stu_Id = 111, Stu_Name = "Praveen", Stu_City="CHN" },
                new Student{ Stu_Id = 222, Stu_Name = "Milen", Stu_City="CHN" },
                new Student{ Stu_Id = 333, Stu_Name = "Vimel", Stu_City="BLR" }
            };


            var City = (from c in Tech where c.Tech_City == "CHN" select c.Tech_Name).Concat
                       (from s in Std where s.Stu_City == "CHN" select s.Stu_Name);


            foreach (var p in City)
                Console.WriteLine(" Name ; {0}", p);
            Console.WriteLine("***************************\n");

        }


    }
    public class Employee
    {
        public int Emp_Id
        {
            get;
            set;
        }

        public string Emp_Name
        {
            get;
            set;
        }
    }


    public class Product
    {
        public int Pro_Id { get; set; }
        public string Pro_Name { get; set; }
    }

    public class Student
    {
        public int Stu_Id { get; set; }
        public string Stu_Name { get; set; }
        public string Stu_City { get; set; }
    }

    public class Teacher
    {
        public int Tech_Id { get; set; }
        public string Tech_Name { get; set; }
        public string Tech_City { get; set; }
    }
}
            