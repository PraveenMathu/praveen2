using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            SBAccount SB = new SBAccount();
            CCAccount CA = new CCAccount();
            double si = SB.Get_Simple_Intrest(95000, 5, 8);
            double tamt = SB.Get_Total_Amount(si, 50000);

            double si1 = CA.Get_Simple_Intrest(95000, 5, 8);
            double tamt1 = SB.Get_Total_Amount(si1, 50000);

            Console.WriteLine("The Simple Intrest = {0}",si);
            Console.WriteLine("The Total Amount  = {0}", tamt);



            Console.WriteLine("The Simple Intrest for CA = {0}", si1);
            Console.WriteLine("The Total Amount for CA  = {0}", tamt1);
            //object o=new object();
            SB.show();
        }
    }

    public abstract class Banking
    {
        public abstract double Get_Simple_Intrest(double pr, int td, short rt);

        public abstract double Get_Total_Amount(double si, double bal);

        public void show()
        {
            Console.WriteLine("This is an concerate method defined within an abstract class");
        }
    }

    public class SBAccount : Banking
    {
        public override double Get_Simple_Intrest(double pr, int td, short rt)
        {
            double si = (pr * td * rt) / 100;
            return si;
        }

        public override double Get_Total_Amount(double si, double bal)
        {
            double tamt = bal + si;
            return tamt;
        }
    }

    public class CCAccount : Banking
    {
        public override double Get_Simple_Intrest(double pr, int td, short rt)
        {
            double si = 0.25 * ((pr * td * rt) / 100);
            return si;
        }

        public override double Get_Total_Amount(double si, double bal)
        {
            double tamt = bal + si;
            return tamt;
        }
    }
}
