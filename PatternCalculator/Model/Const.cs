using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternCalculator.Interface;

namespace PatternCalculator.Model
{
    class Const : IExpr
    {

        private int n;

        public Const(int _n)
        {
            n = _n;
        }
        public int Eval()
        {
            return n;
        }

        
        public override string ToString()
        {
            return n.ToString();
        }
    }
}
