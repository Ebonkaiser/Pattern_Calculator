using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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
    class RunStateCalculation : IState, IRun
    {
        private int x;
        private int y;
        private int selection;
        private string s1;
        private string s2;
        private CalcCollector _inventory;
        private ICommand inst;
        private ICommand listing;
        private BinOp calculation;

        

         public RunStateCalculation(CalcCollector inventory)
         {
             // TODO: Complete member initialization
             this._inventory = inventory;
         }
        public void RunTask()
        {
            //ask what kind of calculation 
            CommandFactory.AddWriter("What kind of operation would you like to perform?").Run();
            CommandFactory.AddWriter("1: Addition \n 2: Subtraction \n 3: Factorial \n 4: Power \n 5. Division \n 6: Multiplication").Run();
            string input = Console.ReadLine();
            if (input != null)
            {
                selection = int.Parse(input);
            }



            calculation = ReturnCalculation(selection);
            CommandFactory.newCmdAdd(_inventory, calculation).Run();
            calculation.Accept(new CalculationVisitor());
           


           

            

        
        }

        private BinOp ReturnCalculation(int selection)
        {
           
            CommandFactory.AddWriter("X: ").Run();
            s1 = Console.ReadLine();
            if (s1 != null)
            {
                x = int.Parse(s1);
            }
            else
            {
                throw new ArgumentNullException();
            }

            CommandFactory.AddWriter("Y: ").Run();
            s2 = Console.ReadLine();
            if (s2 != null)
            {
                y = int.Parse(s2);
            }
            else
            {
                throw new ArgumentNullException();
            }

            switch (selection)
            {
                case 1:
                    BinOp op = ObjectFactory.NewPlus(ObjectFactory.NewConst(x), ObjectFactory.NewConst(y));
                    return op;
                    break;
                case 2:
                    BinOp op1 = ObjectFactory.NewMinus(ObjectFactory.NewConst(x), ObjectFactory.NewConst(y));
                    return op1;
                    break;
                case 3:
                    BinOp op2 = ObjectFactory.NewFactorial(ObjectFactory.NewConst(x), ObjectFactory.NewConst(y));
                    return op2;
                    break;
                case 4:
                    BinOp op3 = ObjectFactory.NewPower(ObjectFactory.NewConst(x), ObjectFactory.NewConst(y));
                    return op3;
                    break;
                case 5:
                    BinOp op4 = ObjectFactory.NewQuot(ObjectFactory.NewConst(x), ObjectFactory.NewConst(y));
                    return op4;
                    break;
                case 6:
                    BinOp op5 = ObjectFactory.NewMult(ObjectFactory.NewConst(x), ObjectFactory.NewConst(y));
                    return op5;
                    break;
            }
            return null;
            

    }

        public void Enter(State state)
        {
            RunTask();
            CommandFactory.AddWriter("###########Returning to Menu##########").Run();
            //send inventory back 
            EnterState e = new EnterState(_inventory);
            state.SetNextState(e);
            state.ChangeState();
        }
    }
}
