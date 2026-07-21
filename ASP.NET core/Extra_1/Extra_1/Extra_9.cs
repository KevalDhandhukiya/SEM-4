using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_1
{
    internal class Calculator
    {
        public void multiply(int a, int b)
        {
            int multiply = a * b;
            Console.WriteLine(multiply);
        }

        public void multiply(double a, double b)
        {

            double multiply = a * b;
            Console.WriteLine(multiply);
        }

        public void multiply(float a, float b)
        {

            float multiply = a * b;
            Console.WriteLine(multiply);
        }
    }
}