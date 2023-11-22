using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.Exercise
{
    public class QuadraticEquationSolver
    {
        private readonly IDiscriminantStrategy strategy;

        public QuadraticEquationSolver(IDiscriminantStrategy strategy)
        {
            this.strategy = strategy;
        }

        public Tuple<Complex, Complex> Solve(double a, double b, double c)
        {
            var disc = new Complex(strategy.CalculateDiscriminant(a, b, c), 0);
            var rootDisc = Complex.Sqrt(disc);
            return Tuple.Create(
              (-b + rootDisc) / (2 * a),
              (-b - rootDisc) / (2 * a)
            );
        }
    }

}
