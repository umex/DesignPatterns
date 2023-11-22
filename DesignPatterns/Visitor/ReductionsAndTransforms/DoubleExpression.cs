using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor.ReductionsAndTransforms
{
    public class DoubleExpression : Expression
    {
        public readonly double Value;

        public DoubleExpression(double value)
        {
            Value = value;
        }

        public override T Reduce<T>(ITransformer<T> transformer)
        {
            return transformer.Transform(this);
        }
    }

}
