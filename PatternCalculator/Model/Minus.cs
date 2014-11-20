using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternCalculator.Interface;

namespace PatternCalculator.Model
{
    class Minus : IOp
    {
        public int Eval(int x, int y)
        {
            return (x - y);
        }

        public override string ToString()
        {
            return "Subtraction";
        }
    }
}
