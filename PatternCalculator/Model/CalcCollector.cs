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
        private Queue<BinOp> _data;
       
        public CalcCollector()
        {
            _data = new Queue<BinOp>();
          
        }



        public int Size()
        {
            return _data.Count;
        }

        public BinOp Get()
        {
            return _data.Dequeue();
        }

        public void AddCalculation(BinOp _op)
        {
            if (_op == null)
            {
                throw new ArgumentNullException();
            }

           _data.Enqueue(_op);
        }

       public BinOp RemoveCalculation()
        {
            if (_data.Count != 0)
            {
                return _data.Dequeue();
            }
            else
            {
                throw new NullReferenceException();
            }
            
        }

        

        public string ListContents()
        {
            string s = string.Empty;
            foreach (BinOp b in _data)
            {
                s = b.ToString();
            }
            return s;
        }

        internal void Clear()
        {
           _data.Clear();
        }
    }
}
