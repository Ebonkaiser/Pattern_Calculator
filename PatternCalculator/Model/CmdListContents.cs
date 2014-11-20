using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternCalculator.Command;
using PatternCalculator.Strategy;

namespace PatternCalculator.Model
{
    class CmdListContents : IWritableCommand
    {
        private CalcCollector _inventory;

        public CmdListContents(CalcCollector c)
        {
            _inventory = c;
        }

        public string Run()
        {
            return ListContents();
           
        }

       
        private string ListContents()
        {
            return _inventory.ListContents();
        }
    }
}
