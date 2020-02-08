using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        //public delegate double saldelegate(int ds, float sd);
        public delegate void aridel(int a, int b);
        static void Main(string[] args)
        {
            //saldelegate deleg = new saldelegate(Getsalary);
            //var salary = deleg.Invoke(30, 800);
            //Console.WriteLine("Salary={0}", salary);
            ////Console.WriteLine("Salary={0}", deleg.Invoke(30, 800));

            //deleg += GetIncentive;
            //var incent = deleg.Invoke(30, 800);
            //Console.WriteLine("Incentive = {0}", incent);

            aridel d = new aridel(add);
            d += sub;
            d += mul;
            d += div;
           d.Invoke(950, 95);


        }

        //public static double Getsalary(int nds,float spd)
        //{
        //    var salary = (nds * spd);
        //    return salary;
        //}

        //public static double GetIncentive(int nds, float spd)
        //{
        //    var incent = 0.1*(nds * spd);
        //    return incent;
        //}

        public static void add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("The Sum of Two Numbers {0} and {1} = {2}", a, b, c);
        }

        public static void sub(int a,int b)
        {
            int c = a - b;
            Console.WriteLine("The Difference of Two Numbers {0} and {1} = {2}", a, b, c);
        }

        public static void mul(int a, int b)
        {
            int c = a * b;
            Console.WriteLine("The Multiplication of Two Numbers {0} and {1} = {2}", a, b, c);
        }

        public static void div(int a, int b)
        {
            int c = a / b;
            Console.WriteLine("The Division of Two Numbers {0} and {1} = {2}", a, b, c);
        }
    }
}
