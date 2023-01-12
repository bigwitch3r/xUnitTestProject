using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitTestProject
{
    public class SimpleCalculator
    {
        public SimpleCalculator() { }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Sub(double a, double b)
        {
            return a - b;
        }

        public double Mult(double a, double b)
        {
            return a * b;
        }

        public double Div(double a, double b)
        {
            return a / b;
        }
    }
}
