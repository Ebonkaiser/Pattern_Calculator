using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternCalculator.Interface;
using PatternCalculator.Model;
using PatternCalculator.Strategy;

namespace PatternCalculator.Visitor
{
    class CalculationVisitor : IVisitor
    {

        public void Visit(BinOp b)
        {
            //Command hiding console writeline
            Console.WriteLine("Answer: " + b.Eval());
        }

        public void Visit(Calculator c)
        {
            Console.WriteLine("Your calculation is listed below:");
        }

    }
}
