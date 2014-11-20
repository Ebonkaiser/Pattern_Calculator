using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternCalculator.Interface;

namespace PatternCalculator.Strategy
{
      class BinOp : IExpr, IElement
    {
        private static IExpr _l;
        private static IExpr _r;
        private static IOp  _op;

        public  BinOp(IExpr l, IOp op, IExpr r) {
       if ((l == null) || (op == null) || (r == null)) {
         throw new NoNullAllowedException();
      }
         _op = op;
         _l = l;
          _r = r;
     }
    
    


     public int Eval()
     {
         return _op.Eval(_l.Eval(), _r.Eval());
     }

     public void Accept(IVisitor visitor)
     {
         // visit by sending command
         visitor.Visit(this);
     }

         public override string ToString()
         {
             StringBuilder CB = new StringBuilder();
             CB.Append(_op.ToString());
             CB.Append(" ");

             CB.Append(_l.ToString());
             CB.Append(" ");
            
             CB.Append(" ");
             CB.Append(_r.ToString());

             return CB.ToString();

         }
    }
}
