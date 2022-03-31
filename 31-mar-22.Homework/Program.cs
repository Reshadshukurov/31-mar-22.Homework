using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_mar_22.Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.Sum(2,4);
            Calculator.Subtract(5, 3);
            Calculator.Multiply(6, 4);
            Calculator.Divide(21, 3);
            Console.WriteLine(Calculator.Sum(2, 4));
            Console.WriteLine(Calculator.Subtract(5, 3));
            Console.WriteLine(Calculator.Multiply(6, 4));
            Console.WriteLine(Calculator.Divide(21, 3));
            Console.ReadLine();

        }
    }
}
