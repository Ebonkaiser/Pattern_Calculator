using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternCalculator.Data;
using PatternCalculator.Interface;

namespace PatternCalculator.Model
{
    class Calculator : IElement
    {
        private List<IElement> elements = new List<IElement>();
        private IExpr l, r;
        public Calculator(IExpr _l, IExpr _r)
        {
            l = _l;
            r = _r;

        }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
            for (int i = 1; i <= 6; i++)
            {
                switch (i)
                {
                    case 1:
                        CommandFactory.AddWriter("###########Returning to Menu##########").Run();
                        Console.Write("Multiplication: ");
                        ExprFactory.NewMult(l, r).Accept(visitor);
                        break;
                    case 2:
                        CommandFactory.AddWriter("###########Returning to Menu##########").Run();
                        Console.Write("Subtraction: ");
                        ExprFactory.NewMinus(l, r).Accept(visitor);
                        break;
                    case 3:
                        CommandFactory.AddWriter("###########Returning to Menu##########").Run();
                        Console.Write("Quotient: ");
                        ExprFactory.NewQuot(l, r).Accept(visitor);
                        break;
                    case 4:
                        CommandFactory.AddWriter("###########Returning to Menu##########").Run();
                        Console.Write("Addition: ");
                        ExprFactory.NewPlus(l, r).Accept(visitor);
                        break;
                    case 5:
                        CommandFactory.AddWriter("###########Returning to Menu##########").Run();
                        Console.Write("Factorial: ");
                        ExprFactory.NewFactorial(l, r).Accept(visitor);
                        break;
                    case 6:
                        CommandFactory.AddWriter("###########Returning to Menu##########").Run();
                        Console.Write("Exponent: ");
                        ExprFactory.NewPower(l, r).Accept(visitor);
                        break;

                }

            }
           
          
        }

      
    }
}
