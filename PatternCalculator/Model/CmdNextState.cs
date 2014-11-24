using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternCalculator.Command;
using PatternCalculator.Data;
using PatternCalculator.FSM;

namespace PatternCalculator.Model
{
  

    class CmdNextState : ICommand
    {
        private CalcCollector _inventory;

        public CmdNextState()
        {
            _inventory = CommandFactory.newInventory();
        }

        public bool Run()
        {
            State state = new State(_inventory);
            state.Start();
            return true;
        }
    }
}
