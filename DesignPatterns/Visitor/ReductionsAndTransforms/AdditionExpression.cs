using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor.ReductionsAndTransforms
{
    public class AdditionExpression : Expression
    {
        public readonly Expression Left, Right;

        public AdditionExpression(Expression left, Expression right)
        {
            Left = left;
            Right = right;
        }

        public override T Reduce<T>(ITransformer<T> transformer)
        {
            var left = Left.Reduce(transformer);
            var right = Right.Reduce(transformer);
            return transformer.Transform(this, left, right);
        }
    }

}
