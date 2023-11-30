using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility.Exercise
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void ManyGoblinsTest()
        {
            var game = new Game();
            var goblin = new Goblin(game);
            game.Creatures.Add(goblin);

            Assert.That(goblin.Attack, Is.EqualTo(1));
            Assert.That(goblin.Defense, Is.EqualTo(1));

            var goblin2 = new Goblin(game);
            game.Creatures.Add(goblin2);

            Assert.That(goblin.Attack, Is.EqualTo(1));
            Assert.That(goblin.Defense, Is.EqualTo(2));

            var goblin3 = new GoblinKing(game);
            game.Creatures.Add(goblin3);

            Assert.That(goblin.Attack, Is.EqualTo(2));
            Assert.That(goblin.Defense, Is.EqualTo(3));
        }

    }
}
