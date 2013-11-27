using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriTest
{
    [TestClass]
    public class UnitTest1
    {
        //Good to know!
        //n = new number
        //nn = negative number
        //d = decimal
        //o = object

        [TestMethod]
        public void isScalene()
        {
            Triangle n1n1n1 = new Triangle(1, 1, 1);
            Assert.IsTrue(n1n1n1.isScalene());
            Triangle n2n1n1 = new Triangle(2, 1, 1);
            Assert.IsFalse(n2n1n1.isScalene());
            Triangle n2n3n1 = new Triangle(2, 3, 1);
            Assert.IsFalse(n2n3n1.isScalene());

            double[] an1n2n3 = new double[3] { 1, 2, 3 };
            double[] an1n3n5 = new double[3] { 1, 3, 5 };

            Triangle on1n2n3 = new Triangle(an1n2n3);
            Assert.IsFalse(on1n2n3.isScalene());
            Triangle on1n3n5 = new Triangle(an1n3n5);
            Assert.IsFalse(on1n3n5.isScalene());

            Point n1n1 = new Point(1, 1);
            Point n1n2 = new Point(1, 2);

            Point[] aon1n2on1n2on1n2 = new Point[3] { n1n2, n1n2, n1n2 };
            Point[] aon1n2on1n1on1n1 = new Point[3] { n1n2, n1n2, n1n2 };

            Triangle oaon1n2on1n2on1n2 = new Triangle(aon1n2on1n2on1n2);
            Assert.IsTrue(oaon1n2on1n2on1n2.isScalene());
            Triangle oaon1n2on1n1on1n1 = new Triangle(aon1n2on1n1on1n1);
            Assert.IsTrue(oaon1n2on1n1on1n1.isScalene());

            Triangle on1n2on1n2on1n2 = new Triangle(n1n2, n1n2, n1n2);
            Assert.IsTrue(on1n2on1n2on1n2.isScalene());
            Triangle on1n2on1n1on1n1 = new Triangle(n1n2, n1n1, n1n1);
            Assert.IsFalse(on1n2on1n1on1n1.isScalene());
        }

        [TestMethod]
        public void isIsosceles()
        {
            Triangle n1n1n1 = new Triangle(1, 1, 1);
            Assert.IsFalse(n1n1n1.isIsosceles());
            Triangle n2n1n1 = new Triangle(2, 1, 1);
            Assert.IsTrue(n2n1n1.isIsosceles());
            Triangle n2n3n1 = new Triangle(2, 3, 1);
            Assert.IsFalse(n2n3n1.isIsosceles());

            double[] an1n2n3 = new double[3] { 1, 2, 3 };
            double[] an1n3n5 = new double[3] { 1, 3, 5 };

            Triangle on1n2n3 = new Triangle(an1n2n3);
            Assert.IsFalse(on1n2n3.isIsosceles());
            Triangle on1n3n5 = new Triangle(an1n3n5);
            Assert.IsFalse(on1n3n5.isIsosceles());

            Point n1n1 = new Point(1, 1);
            Point n1n2 = new Point(1, 2);

            Triangle on1n2on1n2on1n2 = new Triangle(n1n2, n1n2, n1n2);
            Assert.IsFalse(on1n2on1n2on1n2.isIsosceles());
            Triangle on1n2on1n1on1n1 = new Triangle(n1n2, n1n1, n1n1);
            Assert.IsTrue(on1n2on1n1on1n1.isIsosceles());
        }
        [TestMethod]
        public void isEquilateral()
        {
            Triangle n1n1n1 = new Triangle(1, 1, 1);
            Assert.IsFalse(n1n1n1.isEquilateral());
            Triangle n2n1n1 = new Triangle(2, 1, 1);
            Assert.IsFalse(n2n1n1.isEquilateral());
            Triangle n2n3n1 = new Triangle(2, 3, 1);
            Assert.IsTrue(n2n3n1.isEquilateral());

            double[] an1n2n3 = new double[3] { 1, 2, 3 };
            double[] an1n3n5 = new double[3] { 1, 3, 5 };

            Triangle on1n2n3 = new Triangle(an1n2n3);
            Assert.IsTrue(on1n2n3.isEquilateral());
            Triangle on1n3n5 = new Triangle(an1n3n5);
            Assert.IsTrue(on1n3n5.isEquilateral());

            Point n1n1 = new Point(1, 1);
            Point n1n2 = new Point(1, 2);

            Triangle on1n2on1n2on1n2 = new Triangle(n1n2, n1n2, n1n2);
            Assert.IsFalse(on1n2on1n2on1n2.isEquilateral());
            Triangle on1n2on1n1on1n1 = new Triangle(n1n2, n1n1, n1n1);
            Assert.IsFalse(on1n2on1n1on1n1.isEquilateral());
        }
    }
}
