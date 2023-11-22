using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.ComparisonStrategy
{
    public class ComparisonStrategyMain
    {
        public static void Main()
        {
            var people = new List<Person>();

            // equality == != and comparison < = >

            people.Sort(); // meaningless by default

            // sort by name with a lambda
            people.Sort((x, y) => x.Name.CompareTo(y.Name));

            people.Sort(Person.NameComparer);

        }

    }
}
