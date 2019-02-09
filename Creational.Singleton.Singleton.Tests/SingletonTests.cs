﻿using NUnit.Framework;

namespace Creational.Singleton.Singleton.Tests
{
    /// <summary>
    ///     IMPORTANT: be sure to turn off shadow copying for unit tests in R#!
    /// </summary>
    [TestFixture]
    public class SingletonTests
    {
        [Test]
        public void DependantTotalPopulationTest()
        {
            var db = new DummyDatabase();
            var rf = new ConfigurableRecordFinder(db);
            Assert.That(rf.GetTotalPopulation(new[] {"alpha", "gamma"}), Is.EqualTo(4));
        }

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
            var names = new[] {"Seoul", "Mexico City"};
            var tp = rf.TotalPopulation(names);
            Assert.That(tp, Is.EqualTo(17500000 + 17400000));
        }
    }
}