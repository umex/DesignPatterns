using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor.IntrusiveVisitor
{
    public abstract class Expression
    {
        // adding a new operation
        public abstract void Print(StringBuilder sb);
    }

    public class DoubleExpression : Expression
    {
        private double value;

        public DoubleExpression(double value)
        {
            this.value = value;
        }

        public override void Print(StringBuilder sb)
        {
            sb.Append(value);
        }
    }

}
