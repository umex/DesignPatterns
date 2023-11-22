using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor.Exercise
{
    public abstract class ExpressionVisitor
    {
        public abstract void Visit(Value value);
        public abstract void Visit(AdditionExpression ae);
        public abstract void Visit(MultiplicationExpression me);
    }

}
