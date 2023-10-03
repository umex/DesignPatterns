using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.BuilderInheritance
{
    public class BuilderInheritanceMain
    {
        class SomeBuilder : PersonBirthDateBuilder<SomeBuilder>
        {

        }

        public static void Main()
        {
            var me = Person.New
              .Called("Dmitri")
              .WorksAsA("Quant")
              .Born(DateTime.UtcNow)
              .Build();
            Console.WriteLine(me);
        }
    }
}
