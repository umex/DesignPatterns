using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor.AcyclicVisitor
{
    public class ExpressionPrinter : IVisitor,
                                     IVisitor<Expression>,
                                     IVisitor<DoubleExpression>,
                                     IVisitor<AdditionExpression>
    {
        StringBuilder sb = new StringBuilder();

        public void Visit(DoubleExpression de)
        {
            sb.Append(de.Value);
        }

        public void Visit(AdditionExpression ae)
        {
            sb.Append("(");
            ae.Left.Accept(this);
            sb.Append("+");
            ae.Right.Accept(this);
            sb.Append(")");
        }

        public void Visit(Expression obj)
        {
            // default handler?
        }

        public override string ToString() => sb.ToString();
    }

}
