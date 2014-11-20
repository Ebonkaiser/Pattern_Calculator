using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternCalculator.Command;

namespace PatternCalculator.Model
{
    class CmdWrite : ICommand
    {
        private string message;
        public CmdWrite(string _s)
        {
            message = _s;
        }
        public bool Run()
        {
            Console.WriteLine(message);
            return true;
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }

        public void Redo()
        {
            throw new NotImplementedException();
        }
    }
}
