using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor.ReductionsAndTransforms
{
    public abstract class Expression
    {
        public abstract T Reduce<T>(ITransformer<T> transformer);
    }

}
