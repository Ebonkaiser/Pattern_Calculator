using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternCalculator.Command;

namespace PatternCalculator.Model
{
    class CmdDelete : ICommand
    {
        private CalcCollector _inventory;

        public CmdDelete(CalcCollector c)
        {
            _inventory = c;
        }

        public bool Run()
        {
            _inventory.RemoveCalculation();
            return true;
        }
    }
}
