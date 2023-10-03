using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.DetectingDecoratorCycles
{
    // can determine one policy for all classes
    public class ShapeDecoratorWithPolicy<T>
      : ShapeDecorator<T, ThrowOnCyclePolicy>
    {
        public ShapeDecoratorWithPolicy(Shape shape) : base(shape)
        {
        }
    }
}
