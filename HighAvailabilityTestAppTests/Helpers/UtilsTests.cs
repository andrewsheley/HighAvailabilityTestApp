using Microsoft.VisualStudio.TestTools.UnitTesting;
using HighAvailabilityTestApp.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace HighAvailabilityTestApp.Helpers.Tests
{
    [TestClass()]
    public class UtilsTests
    {
        [TestMethod()]
        public void FullNameTest()
        {
            Assert.IsTrue(Utils.FullName("john", "smith") == "smith, john");
        }
    }
}