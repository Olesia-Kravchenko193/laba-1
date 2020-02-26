using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, Z;
            Console.WriteLine("enter an integer a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter an integer b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Z = Math.Pow((a - b), 2);
            Console.WriteLine("Z= " + Z);
        }
    }
}
