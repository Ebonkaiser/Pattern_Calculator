﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCalculator.Interface
{
    interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
