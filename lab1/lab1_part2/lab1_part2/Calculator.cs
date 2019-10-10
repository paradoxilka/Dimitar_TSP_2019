using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_part2
{
    class Calculator
    {
        public double AddNumbers(double val1, double val2)
        { 
            return val1 + val2; 
        }
        public double SubNumbers(double val1, double val2)
        {
            return val1 - val2;
        }
        public double MulNumbers(double val1, double val2)
        {
            return val1 * val2;
        }
        public double DevNumbers(double val1, double val2)
        {
            return val1 / val2;
        }
    }
}
