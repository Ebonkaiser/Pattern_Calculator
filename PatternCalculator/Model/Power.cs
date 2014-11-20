using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternCalculator.Interface;

namespace PatternCalculator.Model
{
    class Power : IOp
    {
        public int Eval(int x, int y)
        {
           
            for (int i = 1; i < y; i++)
            {
                x*=x;
            }
            return x;
        }

        public override string ToString()
        {
            return "Exponential function (power)";
        }

       
    }
}
