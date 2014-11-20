using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternCalculator.Data;
using PatternCalculator.FSM;
using PatternCalculator.Interface;
using PatternCalculator.Model;
using PatternCalculator.Visitor;

namespace PatternCalculator
{
    class Program
    {
       

        //private IElement calculator = new Calculator();
        static void Main(string[] args)
        {

            //Have options
            //1: do calculation
            //choose between list of available calculations
            //then enter values

            //2. View past calculation
            //option to delete and undelete
            //option to run calculation again
           
         //Console.WriteLine("Enter Values Below:");
         //Console.Write("X:");
         //Console.ReadLine();
         //int i1 = int.Parse(Console.ReadLine());
         //Console.Write("Y:");      
         //int i2 = int.Parse(Console.ReadLine());


         //IElement calculator = new Calculator(ExprFactory.NewConst(i1), ExprFactory.NewConst(i2));

         //calculator.Accept(new CalculationVisitor());
            CalcCollector _inventory = CommandFactory.newInventory();
            State state = new State(_inventory);
            state.Start();

          Console.Read();

        }
    }
}
