using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor.DynamicVisitor
{
    public class DoubleExpression : Expression
    {
        public double Value;

        public DoubleExpression(double value)
        {
            Value = value;
        }
    }

}
