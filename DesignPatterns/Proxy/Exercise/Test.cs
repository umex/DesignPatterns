using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy.Exercise
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void TestMethod()
        {
            var p = new Person { Age = 10 };
            var rp = new ResponsiblePerson(p);

            Assert.That(rp.Drive(), Is.EqualTo("too young"));
            Assert.That(rp.Drink(), Is.EqualTo("too young"));
            Assert.That(rp.DrinkAndDrive(), Is.EqualTo("dead"));

            rp.Age = 20;

            Assert.That(rp.Drive(), Is.EqualTo("driving"));
            Assert.That(rp.Drink(), Is.EqualTo("drinking"));
            Assert.That(rp.DrinkAndDrive(), Is.EqualTo("dead"));
        }

    }
}
