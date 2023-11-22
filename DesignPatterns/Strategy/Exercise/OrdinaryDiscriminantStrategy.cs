using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.Exercise
{
    public class OrdinaryDiscriminantStrategy : IDiscriminantStrategy
    {
        public double CalculateDiscriminant(double a, double b, double c)
        {
            return b * b - 4 * a * c;
        }
    }

}
