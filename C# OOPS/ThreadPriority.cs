using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadPriority
{
    class Program
    {
        public static long count1, count2;
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread is Started");

            Thread t1 = new Thread(Inccount1);
            Thread t2 = new Thread(Inccount2);

            t1.Start();
            t2.Start();

            t1.Priority = System.Threading.ThreadPriority.Lowest;
            t2.Priority = System.Threading.ThreadPriority.Highest;

            Thread.Sleep(10000);
            t1.Abort();
            t2.Abort();

            Console.WriteLine("Count1 : {0}", count1);
            Console.WriteLine("Count2 : {0}", count2);

            Console.WriteLine("The MAin thread is exited");
        }

        public static void Inccount1()
        {
            while(true)
            {
                count1 += 1;
            }
            
        }

        public static void Inccount2()
        {
            while(true)
            {
                count2 += 1;
            }
            
        }
    }
}
