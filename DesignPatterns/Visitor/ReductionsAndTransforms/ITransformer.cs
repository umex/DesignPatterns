using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor.ReductionsAndTransforms
{
    public interface ITransformer<T>
    {
        T Transform(DoubleExpression de);
        T Transform(AdditionExpression ae, T left, T right);
    }

}
