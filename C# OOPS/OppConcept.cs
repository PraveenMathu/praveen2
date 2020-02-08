using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPconcept
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(1, "Mohan", 101, "Tech");
            Employee emp2 = new Employee(2, "Kowshik", 102, "Tech");

            emp1.showdata();
            Console.WriteLine("\n");
            emp2.showdata();
           
            Console.WriteLine("\n");

            product p = new product() { PID = 007, PNAME = "Praveen Milk", AMT = 55, QNTY = "500 ml" };
            p.showdata();



           // Console.ReadKey();
        }
    }
    public class Employee
    {
        int empid;     //Access specifier for class is internal by default
        string empname;
        short depid;
        string depname;

        public Employee()
        {

        }

        public Employee (int id,string ename,short did,string dname)
        {
            empid = id;
            empname = ename;
            depid = did;
            depname = dname;
        }

        public void showdata()
        {
            Console.WriteLine("Emp_id: {0}", empid);
            Console.WriteLine("Emp_name: {0}", empname);
            Console.WriteLine("Dep_id: {0}", depid);
            Console.WriteLine("Dep_name: {0}", depname);
        }
       
    }

    //Access Specifier
    //private,protected,public,internal,protected internal

    //private - can only be accessed within the calss where it is defined
    //protected - can be accessed within both base and derived class
    //public - can be accessed anywhere both within or outside of that class or assembly
    //internal - can be accessed only within the current assembly of where that class is defined
    //protected internal - can be accessed within the current assembly and only with in the derived class of that assembely


    public class product
    {
        //int pid;
        //define properties for the class
        public int PID
        {
            get;
            set;
           // get { return pid; }
           // set { pid = value; }
        }
        //automatic properties, complier does the implementation here
        public string PNAME
        {
            get;
            set;
        }

        public double AMT
        {
            get;
            set;
        }

        public string QNTY
        {
            get;
            set;
        }

        public void showdata()
        {
            Console.WriteLine("Prd_id: {0}", PID);
            Console.WriteLine("Prd_name: {0}", PNAME);
            Console.WriteLine("Prd_prise: {0}", AMT);
            Console.WriteLine("prd_Qnty: {0}", QNTY);
        }
    }



}
