using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = { 1, 2, 3, 4, 5 };

            }
            catch
            {

            }
            try
            {
                int a, b, c;
                Console.WriteLine("Enter numerator:");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter denomnator:");
                b = int.Parse(Console.ReadLine());

                if (b == 0)
                    throw new DivideByZeroException("Denominator cannot be Zero");
                else
                {
                    c = a / b;
                    Console.WriteLine("c={0}", c);
                }
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
