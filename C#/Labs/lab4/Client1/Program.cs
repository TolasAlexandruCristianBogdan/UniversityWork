using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            localhost.WebService1 serv= new localhost.WebService1();
            int sum = serv.Add(2, 3);
            Console.WriteLine("The sum is "  + sum.ToString());
            double C=serv.FtoC(2);
            Console.WriteLine("The celsius is " + C.ToString());
            double F = serv.CtoF(2);
            Console.WriteLine("The fahrenheit is " + C.ToString());
            string datati = serv.dt();
            Console.WriteLine(datati.ToString());
            
            Array T = serv.GetNames();
            foreach (string name in T) {Console.WriteLine(name);}
            double E = serv.LtoE(2);
            Console.WriteLine("The euro is " + E.ToString());
            double L= serv.EtoL(2);
            Console.WriteLine("The lei is " + L.ToString());
            Console.ReadKey();
        }
    }
}
