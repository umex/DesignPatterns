using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor.ClassicVisitor
{
    public interface IExpressionVisitor
    {
        void Visit(DoubleExpression de);
        void Visit(AdditionExpression ae);
    }

}
