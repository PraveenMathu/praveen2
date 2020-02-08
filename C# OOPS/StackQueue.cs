using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack and Queue data structures

            //Stack is last in first out (LIFO) where queue is called first in first out (FIFO)
            Stack<float> fnum = new Stack<float>();

            fnum.Push(10.90f);
            fnum.Push(11);
            fnum.Push(12.2f);
            fnum.Push(13.021f);

            foreach (var ob in fnum)
                Console.WriteLine(ob);
            Console.WriteLine("\n\n");
            fnum.Pop();

            foreach (var ob in fnum)
                Console.WriteLine(ob);
            Console.WriteLine("\n\n");

            Queue<double> qnum = new Queue<double>();

            qnum.Enqueue(10.90);
            qnum.Enqueue(11);
            qnum.Enqueue(12.2);
            qnum.Enqueue(13.021);

            foreach (var ob in qnum)
                Console.WriteLine(ob);
            Console.WriteLine("\n\n");
            qnum.Dequeue();

            foreach (var ob in qnum)
                Console.WriteLine(ob);

            int a = 50; int b = 30;
            Console.WriteLine("Before Swaping {0} and {1}", a, b);

            Swap<int>(ref a, ref b);

            Console.WriteLine("After Swaping {0} and {1}",a,b);

            string s1 = "Hai"; string s2 = "All";
            Console.WriteLine("Before Swaping {0} and {1}", s1, s2);

            Swap<string>(ref s1, ref s2);

            Console.WriteLine("After Swaping {0} and {1}", s1, s2);


        }

        public static void Swap<T>(ref T a,ref T b)
        {
            T c;
            c = a;
            a = b;
            b = c;
        }
    }
}
