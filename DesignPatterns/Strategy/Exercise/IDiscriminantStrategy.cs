using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.Exercise
{
    public interface IDiscriminantStrategy
    {
        double CalculateDiscriminant(double a, double b, double c);
    }

}
