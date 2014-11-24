using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternCalculator.Command;
using PatternCalculator.Data;
using PatternCalculator.Interface;
using PatternCalculator.Model;
using PatternCalculator.Strategy;
using PatternCalculator.Visitor;

namespace PatternCalculator.FSM
{
    class RunStateViewHistory : IState, IRun
    {
        private ICommand writer; 
        private CalcCollector _inventory;
        IState NextState { get; set; }
         public RunStateViewHistory()
        {
            
        }

         public RunStateViewHistory(CalcCollector inventory)
         {
             
             this._inventory = inventory;
         }
        public void RunTask()
        {
            int selection;
            //create command to list inventory contents
            string ret =
                string.Format(
                    "Past Calculations listed Below: \n {0} \n Do you wish to: \n 1: Run last calculation \n 2: Clear list \n 3: Return to Main Menu",
                    _inventory.ListContents());
           CommandFactory.AddWriter(ret).Run();

            string input = Console.ReadLine();

            if (input != null)
            {
                selection = int.Parse(input);
            }
            else
            {
                throw new NullReferenceException();
            }
            switch (selection)
            {
                case 1:

                    IElement b = CommandFactory.newCmdGet(_inventory).Run();
                    //create a command to get
                    
                  
                    

                    //create calculation 
                    if (b != null){
                        //add calculationvisitor to factory
                        b.Accept(ObjectFactory.NewVisitor());
                        //create add command to add calculation
                        CommandFactory.newCmdAdd(_inventory, b).Run();
                        //create command to remove calculation
                        RunTask();
                    }
                    else { throw new NullReferenceException();}
                       break;
                case 2:
                    //create clear command
                    CommandFactory.newCmdClear(_inventory).Run();
                    break;
                        //create next state command
                case 3: NextState = new EnterState(_inventory);
                        NextState.Enter(new State(_inventory));
                        break;
            }
            


        }

        public void Enter(State state)
        {
            RunTask();
            CommandFactory.AddWriter("###########Executing Menu State Change##########").Run();
            state.SetNextState(new EnterState(_inventory));
            state.ChangeState();
        }
        //TODO  finish running last calculations object duplication in queue, make factory method?


        
    }
}
