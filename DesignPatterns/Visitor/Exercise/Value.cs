using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor.Exercise
{
    public class Value : Expression
    {
        public readonly int TheValue;

        public Value(int value)
        {
            TheValue = value;
        }

        public override void Accept(ExpressionVisitor ev)
        {
            ev.Visit(this);
        }
    }

}
