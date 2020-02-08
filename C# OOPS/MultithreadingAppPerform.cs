using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace MulthitreadAppPerform
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch s = new Stopwatch();
            s.Start();
            inccount1();
            inccount2();
            s.Stop();

            Stopwatch s1 = new Stopwatch();
            s1.Start();

            Thread t1 = new Thread(inccount1);
            Thread t2 = new Thread(inccount2);

            t1.Start();
            t2.Start();

            s1.Stop();

            Console.WriteLine(s.ElapsedMilliseconds);
            Console.WriteLine(s1.ElapsedMilliseconds);

        }

        public static void inccount1()
        {
            long Count1 = 0;
            for (int i = 1; i <= 100000000; i++)
                Count1++;

            Console.WriteLine(Count1);
        }

        public static void inccount2()
        {
            long Count2 = 0;
            for (int i = 1; i <= 100000000; i++)
                Count2++;

            Console.WriteLine(Count2);
        }
    }
}
