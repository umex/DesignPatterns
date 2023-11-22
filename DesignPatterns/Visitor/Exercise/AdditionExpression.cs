using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor.Exercise
{
    public class AdditionExpression : Expression
    {
        public readonly Expression LHS, RHS;

        public AdditionExpression(Expression lhs, Expression rhs)
        {
            LHS = lhs;
            RHS = rhs;
        }

        public override void Accept(ExpressionVisitor ev)
        {
            ev.Visit(this);
        }
    }

}
