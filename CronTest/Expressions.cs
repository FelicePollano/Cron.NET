using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Quartz;

namespace CronTest
{
    [TestFixture]
    public class Expressions
    {
        [Test]
        public void LastOfTheMonth()
        {
            var exp = new CronExpression("* * * L * ?");
            Assert.IsTrue(exp.IsSatisfiedBy(new DateTime(2000, 1, 31)));
            Assert.IsTrue(exp.IsSatisfiedBy(new DateTime(2000, 2, 29)));
            Assert.IsFalse(exp.IsSatisfiedBy(new DateTime(2000, 2, 28)));
        }
        [Test]
        public void EveryTimeButWE()
        {
            var exp = new CronExpression("* * * ? * MON-FRI");
            Assert.IsTrue(exp.IsSatisfiedBy(new DateTime(2010, 6, 16)));
            Assert.IsFalse(exp.IsSatisfiedBy(new DateTime(2010, 6, 19)));
           
        }
    }
}
