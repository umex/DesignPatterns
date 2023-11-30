using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interpreter.Exercise
{
    [TestFixture]
    public class TestSuite
    {
        [Test]
        public void Test()
        {
            var ep = new ExpressionProcessor();
            ep.Variables.Add('x', 5);

            Assert.That(ep.Calculate("1"), Is.EqualTo(1));

            Assert.That(ep.Calculate("1+2"), Is.EqualTo(3));

            Assert.That(ep.Calculate("1+x"), Is.EqualTo(6));

            Assert.That(ep.Calculate("1+xy"), Is.EqualTo(0));
        }
    }

}
