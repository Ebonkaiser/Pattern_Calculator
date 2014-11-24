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
    class EnterState : IState
    {
        public CalcCollector _inventory;
        public EnterState(CalcCollector c)
        {
            if (c == null)
            {
                _inventory = CommandFactory.newInventory();
            }
            _inventory = c;
        }

        public void Enter(State state)
        {
            //Have options
            //1: do calculation
            //choose between list of available calculations
            //then enter values

            //2. View past calculation
            //option to delete and undelete
            //option to run calculation again


            CommandFactory.AddWriter("Choose from options below:").Run();
            CommandFactory.AddWriter("1: Do calculation" + "\n" + "2: View past Calculations" + "\n" + "3: Quit").Run();
            
            
            string s1 = Console.ReadLine();
            int i1 = 0;
            
            if (s1 != null)
            {
                i1 = int.Parse(s1);
            }
            if (i1 != 0)
            {
                state.SetNextState(new RunStateMenuSelect(i1, _inventory));
                state.ChangeState();
            }
            else
            {
                throw new ArgumentException("Invalid argument, enter number from menu");
            }
           
            
        }
    }
}
