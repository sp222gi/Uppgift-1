using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void isIsosceles()
        {
            Triangle tri = new Triangle(1.0, 0.5, 1.0);
            Assert.IsTrue(tri.isIsosceles());
        }
    }
}
