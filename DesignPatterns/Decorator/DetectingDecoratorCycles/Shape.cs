﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.DetectingDecoratorCycles
{
    public abstract class Shape
    {
        public virtual string AsString() => string.Empty;
    }

}
