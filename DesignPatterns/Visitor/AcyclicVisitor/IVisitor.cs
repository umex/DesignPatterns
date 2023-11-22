using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor.AcyclicVisitor
{
    public interface IVisitor<TVisitable>
    {
        void Visit(TVisitable obj);
    }

    public interface IVisitor { } // marker interface
}
