using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor.Exercise
{
    public abstract class Expression
    {
        public abstract void Accept(ExpressionVisitor ev);
    }

}
