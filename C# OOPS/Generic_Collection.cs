using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList items = new ArrayList(100);

            items.Add("Helo World");
            items.Add(10);
            items.Add(DateTime.Now);
            items.Add(true);

            foreach (object o in items)
                Console.WriteLine(o.ToString());

            List<int> mylist = new List<int>();                               //Generic Collection Class
            mylist.Add(10);
            mylist.Add(20);
            mylist.Add(30);

            foreach (object ob in mylist)
                Console.WriteLine(ob.ToString());


            List<string> ls = new List<string>() { "Gokul","Kowshik","Praveen","Mohan","Vimal"};   //Collectoin Initilizer

            foreach (object obj in ls)
                Console.WriteLine(obj);


            Dictionary<int, string> fruits = new Dictionary<int, string>();
            fruits.Add(1, "Apple");
            fruits.Add(2, "Orange");
            fruits.Add(3, "Banana");
            fruits.Add(4, "Pineapple");
            fruits.Add(5, "Grapes");


            foreach (KeyValuePair<int, string> go in fruits)
                Console.WriteLine("Key -> {0}  value -> {1}", go.Key, go.Value);

            //deleting from the list
            fruits.Remove(4);
            foreach (KeyValuePair<int, string> go in fruits)
                Console.WriteLine("Key -> {0}  value -> {1}", go.Key, go.Value);


            SortedDictionary<int, string> sd = new SortedDictionary<int, string>();
            sd.Add(3, "THINKPAD");
            sd.Add(1, "NOTEPAD");
            sd.Add(5, "SMARTPHONE");
            sd.Add(4, "CD_PHONE");
            sd.Add(2, "CD_MICROPHONE");


            foreach (KeyValuePair<int, string> kv in sd)
                Console.WriteLine("Key -> {0}  value -> {1}", kv.Key, kv.Value);

            Employee emp = new Employee() {Emp_id= 1,Emp_Name= "Aravind",dep= "Admin" };
            Employee emp1 = new Employee() { Emp_id = 2, Emp_Name = "Milen", dep = "Tech" };
            Employee emp2 = new Employee() { Emp_id = 3, Emp_Name = "Praveen", dep = "Support" };

            //emp.Emp_det();
            //emp1.Emp_det();
            //emp2.Emp_det();

            List<Employee> Employees = new List<Employee>();
            Employees.Add(new Employee() { Emp_id = 1, Emp_Name = "Aravind", dep = "Admin" });
            Employees.Add(new Employee() { Emp_id = 2, Emp_Name = "Milen", dep = "Tech" });
            Employees.Add(new Employee() { Emp_id = 3, Emp_Name = "Praveen", dep = "Support" });

            foreach (var empy in Employees)
                Console.WriteLine("Emp_id -> {0}  Amp_Name -> {1}  Emp_Dep -> {2}", empy.Emp_id, empy.Emp_Name,empy.dep);


        }
    }

    class Employee
    {
        public int Emp_id
        {
            get;
            set;
        }
        public string Emp_Name
        {
            get;
            set;
        }
        public string dep
        {
            get;
            set;
        }

        public void Emp_det( )
        {

            Console.WriteLine("Emp_Id : {0}, Emo_Name : {1}, Emp_Dep : {2}", Emp_id, Emp_Name, dep);
        }
    }
}
