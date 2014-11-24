using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternCalculator.Command;
using PatternCalculator.Interface;
using PatternCalculator.Strategy;

namespace PatternCalculator.Model
{
    class CalcCollector : ICalcCollector
    {
        private Stack<BinOp> _data;
       
        public CalcCollector()
        {
            _data = new Stack<BinOp>();
          
        }



        public int Size()
        {
            return _data.Count;
        }

        public BinOp Get()
        {
            return _data.Peek();
        }

        public void AddCalculation(BinOp _op)
        {
            if (_op == null)
            {
                throw new ArgumentNullException();
            }

           _data.Push(_op);
        }

       public BinOp RemoveCalculation()
        {
            if (_data.Count != 0)
            {
                return _data.Pop();
            }
            else
            {
                throw new NullReferenceException();
            }
            
        }

        

        public string ListContents()
        {
            StringBuilder sb = new StringBuilder();
            
            foreach (BinOp b in _data)
            {
                sb.Append(b.ToString() + "\n");
            }
            return sb.ToString();
        }

        internal void Clear()
        {
           _data.Clear();
        }
    }
}
