using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[6] { 85,95,75,98,84,91};
            Result r = new Result();
            var avg = r.getaveragemarks(marks);
            r.displayaverage(avg);
            r.showgrade(avg);
        }
    }

    //All interface can have only method prototypes without any concreate methods
    public interface IExam
    {
        double getaveragemarks(int[] marks);
        void displayaverage(double avg);
    }

    public interface IStudent
    {
        void showgrade(double avg);

    }

    public class Result : IExam, IStudent
    {
        public void displayaverage(double avg)
        {
            Console.WriteLine("The Average Mark = {0}", avg);
        }

        public double getaveragemarks(int[] marks)
        {
            int total = 0;
            double avg;
            for (int i = 0; i < marks.Length; i++)
                total += marks[i];

            avg = total / marks.Length;
            return avg;
        }

        public void showgrade(double avg)
        {
            if (avg > 70)
                Console.WriteLine("Passed in Distinction");
            else
                Console.WriteLine("Not in Distinction");
        }
    }
}
