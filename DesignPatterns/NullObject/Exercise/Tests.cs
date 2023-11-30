using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.NullObject.Exercise
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void SingleCallTest()
        {
            var a = new Account(new NullLog());
            a.SomeOperation();
        }

        [Test]
        public void ManyCallsTest()
        {
            var a = new Account(new NullLog());
            for (int i = 0; i < 100; ++i)
                a.SomeOperation();
        }
    }

}
