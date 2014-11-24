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
    using PatternCalculator.Data;

    class CalculationVisitor : IVisitor
    {

        public void Visit(BinOp b)
        {
            //Command hiding console writeline
            CommandFactory.AddWriter("Answer: " + b.Eval()).Run();
            Console.ReadLine();

        }

     

    }
}
