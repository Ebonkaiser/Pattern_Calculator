using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternCalculator.Strategy;

namespace PatternCalculator.Interface
{
    interface ICalcCollector
    {
        int Size();

        BinOp Get();
    }
}
