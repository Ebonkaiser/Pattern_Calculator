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
     class State
    {
        IState NextState { get; set; }
         public CalcCollector _inventory;
        public State(CalcCollector c)
        {
            if (c == null)
            {
                _inventory = CommandFactory.newInventory();
            }
        }
        public void Start()
        {
            NextState = new EnterState(_inventory);
            NextState.Enter(this);
        }

        public void ChangeState()
        {
            CommandFactory.AddWriter("###########Executing...##########").Run();
            NextState.Enter(this);
        }

         public void SetNextState(IState state)
         {
             NextState = state;
         }

         public IState GetNextState()
         {
             return NextState;
         }
    }
}
