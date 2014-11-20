using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternCalculator.Interface;
using PatternCalculator.Model;
using PatternCalculator.Strategy;
using PatternCalculator.Visitor;

namespace PatternCalculator.Data
{
    class ExprFactory
    {
        private ExprFactory()
        {
        }

        static public IExpr NewConst(int n)
        {
            return new Const(n);
        }

        static public BinOp NewMult(IExpr l, IExpr r)
        {
            return new BinOp(l, new Multiply(), r);
        }

        static public BinOp NewPlus(IExpr l, IExpr r)
        {
            return new BinOp(l, new Plus(), r);
        }

        static public BinOp NewMinus(IExpr l, IExpr r)
        {
            return new BinOp(l, new Minus(), r);
        }

        static public BinOp NewFactorial(IExpr l, IExpr r)
        {
            return new BinOp(l, new Factorial(), r);
        }

        static public BinOp NewPower(IExpr l, IExpr r)
        {
            return new BinOp(l, new Power(), r);
        }

        static public BinOp NewQuot(IExpr l, IExpr r)
        {
            return new BinOp(l, new Quot(), r);
        }



         static public IVisitor NewVisitor()
        {
            return new CalculationVisitor();
        }
    }
}
