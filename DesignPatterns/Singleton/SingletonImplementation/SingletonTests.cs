﻿using Autofac;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton.SingletonImplementation
{
    /// <summary>
    /// IMPORTANT: be sure to turn off shadow copying for unit tests in R#!
    /// </summary>
    [TestFixture]
    public class SingletonTests
    {
        [Test]
        public void IsSingletonTest()
        {
            var db = SingletonDatabase.Instance;
            var db2 = SingletonDatabase.Instance;
            Assert.That(db, Is.SameAs(db2));
            Assert.That(SingletonDatabase.Count, Is.EqualTo(1));
        }

        [Test]
        public void SingletonTotalPopulationTest()
        {
            // testing on a live database
            var rf = new SingletonRecordFinder();
            var names = new[] { "Seoul", "Mexico City" };
            int tp = rf.TotalPopulation(names);
            Assert.That(tp, Is.EqualTo(17500000 + 17400000));
        }

        [Test]
        public void DependantTotalPopulationTest()
        {
            var db = new DummyDatabase();
            var rf = new ConfigurableRecordFinder(db);
            Assert.That(
              rf.GetTotalPopulation(new[] { "alpha", "gamma" }),
              Is.EqualTo(4));
        }

        [Test]
        public void DIPopulationTest()
        {
            var cb = new ContainerBuilder();
            cb.RegisterType<OrdinaryDatabase>().As<IDatabase>().SingleInstance();
            cb.RegisterType<ConfigurableRecordFinder>();
            using(var c = cb.Build())
            {
                var rf = c.Resolve<ConfigurableRecordFinder>();
                Assert.That(rf.GetTotalPopulation(new[] { "alpha", "gamma" }),Is.EqualTo(4));
            }
        }

    }
}
