using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace test.tests
{
    [TestFixture]
    public class TestTests
    {
        [Test]
        public void VerifyTest()
        {
            var result = SumTest.Sum(3, 4);
            Assert.AreEqual(result, 7);
        }


    }
}
