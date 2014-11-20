using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternCalculator.Strategy;

namespace PatternCalculator.Command
{
     interface IGettableCommand
    {

        BinOp Run();

       
    }
}
