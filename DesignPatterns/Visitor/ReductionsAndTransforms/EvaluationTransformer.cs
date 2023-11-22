using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor.ReductionsAndTransforms
{
    public class EvaluationTransformer : ITransformer<double>
    {
        public double Transform(DoubleExpression de) => de.Value;

        public double Transform(AdditionExpression ae, double left, double right)
        {
            return left + right;
        }
    }

}
