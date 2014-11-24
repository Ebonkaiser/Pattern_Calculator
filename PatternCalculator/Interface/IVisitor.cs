using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternCalculator.Model;
using PatternCalculator.Strategy;

namespace PatternCalculator.Interface
{
    interface IVisitor
    {
        void Visit(BinOp b);
       
      
    }
}
