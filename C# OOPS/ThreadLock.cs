using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadLock
{
    class ThreadLock
    {
        static void Main(string[] args)
        {
            ThreadLock tl = new ThreadLock();

            Thread t1 = new Thread(tl.Display);
            Thread t2 = new Thread(tl.Display);
            Thread t3 = new Thread(tl.Display);

            t1.Start();
            t2.Start();
            t3.Start();
        }

        public void Display()
        {
            lock(this)
            {
                Console.Write("[C sharp is an ");
                Thread.Sleep(5000);
                Console.WriteLine("object oriented Program]");
            }
            
        }
    }
}
