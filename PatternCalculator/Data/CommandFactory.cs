using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternCalculator.Command;
using PatternCalculator.Interface;
using PatternCalculator.Model;
using PatternCalculator.Strategy;

namespace PatternCalculator.Data
{
    class CommandFactory
    {
        internal static ICommand AddWriter(string s)
        {
            return new CmdWrite(s);
        }

        internal static CalcCollector newInventory()
        {
            return new CalcCollector();
        }

        internal static CmdAdd newCmdAdd(CalcCollector _inventory, IElement b)
        {
            return new CmdAdd(_inventory, b);
        }

        internal static CmdGet newCmdGet(CalcCollector _inventory)
        {
            return new CmdGet(_inventory);
        }

        internal static CmdClear newCmdClear(CalcCollector _inventory)
        {
            return new CmdClear(_inventory);
        }

        internal static CmdNextState newCmdStartProgram()
        {
            return new CmdNextState();
        }
    }
}
