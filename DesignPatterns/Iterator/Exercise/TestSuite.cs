using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator.Exercise
{
    [TestFixture]
    public class TestSuite
    {
        [Test]
        public void Test()
        {
            var node = new Node<char>('a',
              new Node<char>('b',
                new Node<char>('c'),
                new Node<char>('d')),
              new Node<char>('e'));
            Assert.That(new string(node.PreOrder.ToArray()), Is.EqualTo("abcde"));
        }
    }
}
