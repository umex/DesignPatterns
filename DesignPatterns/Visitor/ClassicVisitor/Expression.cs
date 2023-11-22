using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor.ClassicVisitor
{
    public abstract class Expression
    {
        public abstract void Accept(IExpressionVisitor visitor);
    }

}
