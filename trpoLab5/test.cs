﻿using NUnit.Framework;

namespace trpoLab5
{
    [TestFixture]
    class test
    {
        [TestCase]
        public void Conv()
        {
            function f = new function();
            Assert.AreEqual(5.08, f.Conv(2));
        }
    }
}