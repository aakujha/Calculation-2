using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 5;
            double b = 10;
            double sum = add(a, b);
            double product = multiply(a, b);
            Console.WriteLine("sum ={0}", sum);
            Console.WriteLine("product ={0}", product);
        }

        static double add(double a, double b)
        {
            return a + b;
        }

        static double multiply(double a, double b)
        {
            return a * b;
        }
    }
}
