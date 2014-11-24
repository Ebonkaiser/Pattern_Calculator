using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternCalculator.Data;
using PatternCalculator.Interface;
using PatternCalculator.Model;

namespace PatternCalculator.FSM
{
    using System.Net.Mime;

    class RunStateMenuSelect : IState, IRun
    {
        private int selection;

        private RunStateViewHistory ViewHistory = null;
        private RunStateCalculation runCalculation = null;
        private CalcCollector _inventory;
        

        public RunStateMenuSelect(int i1, CalcCollector c)
        {
            //recieve inventory
            if (c == null)
            {
                _inventory = CommandFactory.newInventory();
            }
            else
            {
                _inventory = c;
            }
            selection = i1;
        }

        public void RunTask()
        {
            switch (selection)
            {                             //send inventory
                case 1: runCalculation = new RunStateCalculation(_inventory);
                    break;
                case 2: ViewHistory = new RunStateViewHistory(_inventory);
                    break;
                case 3:
                        Environment.Exit(0);
                    break;
                default:
                    CommandFactory.AddWriter("Invalid Entry").Run();
                    break;
            }
        }

        public void Enter(State state)
        {
            CommandFactory.AddWriter("###########Executing Menu State Change##########").Run();
            RunTask();
            if (ViewHistory != null)
            {
                state.SetNextState(ViewHistory);
                state.ChangeState();

            }else if (runCalculation != null)
            {
                state.SetNextState(runCalculation);
                state.ChangeState();
            }
            else if (runCalculation == null && ViewHistory == null)
            {
                state.SetNextState(new EnterState(_inventory));
            }
            
        }
    }
}
