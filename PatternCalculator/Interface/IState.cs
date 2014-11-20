using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternCalculator.FSM;

namespace PatternCalculator.Interface
{
     interface IState
    {
        void Enter(State state);
    }
}
