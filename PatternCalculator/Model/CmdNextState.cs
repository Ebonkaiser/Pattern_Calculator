using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCalculator.Model
{
    class CmdNextState
    {
        private CalcCollector _inventory;

        public CmdNextState(CalcCollector c)
        {
            _inventory = c;
        }
    }
}
