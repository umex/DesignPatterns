using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor.AcyclicVisitor
{
    public abstract class Expression
    {
        public virtual void Accept(IVisitor visitor)
        {
            if (visitor is IVisitor<Expression> typed)
                typed.Visit(this);
        }
    }

}
