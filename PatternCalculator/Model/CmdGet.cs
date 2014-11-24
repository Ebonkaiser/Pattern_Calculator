using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternCalculator.Command;
using PatternCalculator.Strategy;

namespace PatternCalculator.Model
{
    class CmdGet : IGettableCommand
    {
        private CalcCollector _inventory;

        public CmdGet(CalcCollector c)
        {
            _inventory = c;
        }

        public BinOp Run()
        {
            if (_inventory.Size() != 0)
            {
                return _inventory.Get();
            }
            else
            {
                throw new NullReferenceException();
            }
        }
    }
}
