using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.FunctionalBuilder
{
    public static class PersonBuilderExtensions
    {
        public static PersonBuilder WorksAsA
          (this PersonBuilder builder, string position)
        {
            builder.Actions.Add(p =>
            {
                p.Position = position;
            });
            return builder;
        }
    }
}
