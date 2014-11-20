using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternCalculator.Command;
using PatternCalculator.Interface;
using PatternCalculator.Strategy;

namespace PatternCalculator.Model
{
    class CmdAdd : ICommand
    {
        private CalcCollector _inventory;
        private IElement e;

        public CmdAdd(CalcCollector c, IElement b)
        {
            _inventory = c;
            e = b;
        }

        public bool Run()
        {
            _inventory.AddCalculation((BinOp)e);
            return true;
        }
    }
}
