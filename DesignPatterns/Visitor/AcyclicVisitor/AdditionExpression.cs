using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor.AcyclicVisitor
{
    public class AdditionExpression : Expression
    {
        public Expression Left;
        public Expression Right;

        public AdditionExpression(Expression left, Expression right)
        {
            Left = left;
            Right = right;
        }

        public override void Accept(IVisitor visitor)
        {
            if (visitor is IVisitor<AdditionExpression> typed)
                typed.Visit(this);
        }
    }

}
