using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor.ClassicVisitor
{
    public class DoubleExpression : Expression
    {
        public double Value;

        public DoubleExpression(double value)
        {
            Value = value;
        }

        public override void Accept(IExpressionVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

}
