using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor.ReductionsAndTransforms
{
    public class PrintTransformer : ITransformer<string>
    {
        public string Transform(DoubleExpression de)
        {
            return de.Value.ToString();
        }

        public string Transform(AdditionExpression ae, string left, string right)
        {
            return $"({left} + {right})";
        }
    }

}
