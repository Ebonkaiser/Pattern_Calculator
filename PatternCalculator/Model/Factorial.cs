using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternCalculator.Interface;

namespace PatternCalculator.Model
{
    class Factorial : IOp
    {
        public int Eval(int x, int y)
        {
            if (x == 0)
            {
                return 1;
            }

            return x*this.Eval(x - 1, 0);
        }

        public override string ToString()
        {
            return "Factorial";
        }


    }
}
