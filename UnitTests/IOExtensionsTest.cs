using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

using NUnit.Framework;

using Atmosphere.Extensions;

namespace Atmosphere.UnitTests
{
    [TestFixture]
    public class IOExtensionsTest
    {
        private FileInfo alpha1 = new FileInfo("../../TestData/IOExtensions/alpha1.txt");
        private FileInfo alpha2 = new FileInfo("../../TestData/IOExtensions/alpha2.txt");
        private FileInfo beta1 = new FileInfo("../../TestData/IOExtensions/beta1.txt");
        private FileInfo beta2 = new FileInfo("../../TestData/IOExtensions/beta2.txt");

        [Test]
        public void TestSame()
        {
            Assert.IsTrue(alpha1.AreContentsSame(alpha1));
            Assert.IsTrue(alpha2.AreContentsSame(alpha2));
            Assert.IsTrue(alpha1.AreContentsSame(alpha2));
            Assert.IsTrue(alpha2.AreContentsSame(alpha1));
            
            Assert.IsTrue(beta1.AreContentsSame(beta1));
            Assert.IsTrue(beta2.AreContentsSame(beta2));
            Assert.IsTrue(beta1.AreContentsSame(beta2));
            Assert.IsTrue(beta2.AreContentsSame(beta1));
        }

        [Test]
        public void TestNotSame()
        {
            Assert.IsFalse(alpha1.AreContentsSame(beta1));
            Assert.IsFalse(beta1.AreContentsSame(alpha1));
            Assert.IsFalse(alpha1.AreContentsSame(beta2));
            Assert.IsFalse(beta1.AreContentsSame(alpha1));
        }
    }
}

