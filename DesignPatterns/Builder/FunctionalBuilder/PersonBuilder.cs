using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.FunctionalBuilder
{
    public sealed class PersonBuilder
    {
        public readonly List<Action<Person>> Actions
          = new List<Action<Person>>();

        public PersonBuilder Called(string name)
        {
            Actions.Add(p => { p.Name = name; });
            return this;
        }

        public Person Build()
        {
            var p = new Person();
            Actions.ForEach(a => a(p));
            return p;
        }
    }
}
