using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor.Exercise
{
    public class MultiplicationExpression : Expression
    {
        public readonly Expression LHS, RHS;

        public MultiplicationExpression(Expression lhs, Expression rhs)
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
