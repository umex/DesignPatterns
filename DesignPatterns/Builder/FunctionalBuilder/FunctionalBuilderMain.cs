using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.FunctionalBuilder
{
    public class FunctionalBuilder
    {
        public static void Main(string[] args)
        {
            var pb = new PersonBuilder();
            var person = pb.Called("Dmitri").WorksAsA("Programmer").Build();
        }
    }
}
