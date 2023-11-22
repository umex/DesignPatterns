using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor.ReductionsAndTransforms
{
    public class SquareTransformer : ITransformer<Expression>
    {
        public Expression Transform(DoubleExpression de)
        {
            return new DoubleExpression(de.Value * de.Value);
        }

        public Expression Transform(AdditionExpression ae, Expression left, Expression right)
        {
            return new AdditionExpression(left, right);
        }
    }

}
