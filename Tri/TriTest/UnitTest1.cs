using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LiksidigScalene()
        {
            Triangle liksidig = new Triangle(1, 1, 1);
            Assert.IsFalse(liksidig.isScalene());
        }
        [TestMethod]
        public void LiksidigIsosceles()
        {
            Triangle liksidig = new Triangle(1, 1, 1);
            Assert.IsFalse(liksidig.isIsosceles());
        }
        [TestMethod]
        public void LiksidigEquilateral()
        {
            Triangle liksidig = new Triangle(1, 1, 1);
            Assert.IsTrue(liksidig.isEquilateral());
        }
        [TestMethod]
        public void LikbentScalene()
        {
            Triangle likbent = new Triangle(1, 2, 2);
            Assert.IsFalse(likbent.isScalene());
        }
        [TestMethod]
        public void LikbentIsosceles()
        {
            Triangle likbent = new Triangle(1, 2, 2);
            Assert.IsTrue(likbent.isIsosceles());
        }
        [TestMethod]
        public void LikbentEquilateral()
        {
            Triangle likbent = new Triangle(1, 2, 2);
            Assert.IsFalse(likbent.isEquilateral());
        }
        [TestMethod]
        public void OlikScalene()
        {
            Triangle olik = new Triangle(3, 4, 5);
            Assert.IsTrue(olik.isScalene());
        }
        [TestMethod]
        public void OlikIsosceles()
        {
            Triangle olik = new Triangle(3, 4, 5);
            Assert.IsFalse(olik.isIsosceles());
        }
        [TestMethod]
        public void OlikEquilateral()
        {
            Triangle olik = new Triangle(3, 4, 5);
            Assert.IsFalse(olik.isEquilateral());
        }



        [TestMethod]
        public void LikbentArrayScalene()
        {
            double[] likbentDouble = new double[3] { 5, 5, 7 };
            Triangle LikbentArray = new Triangle(likbentDouble);
            Assert.IsFalse(LikbentArray.isScalene());
        }
        [TestMethod]
        public void LikbentArrayIsoSceles()
        {
            double[] likbentDouble = new double[3] { 5, 5, 7 };
            Triangle LikbentArray = new Triangle(likbentDouble);
            Assert.IsTrue(LikbentArray.isIsosceles());
        }
        [TestMethod]
        public void LikbentArrayEquilateral()
        {
            double[] likbentDouble = new double[3] { 5, 5, 7 };
            Triangle LikbentArray = new Triangle(likbentDouble);

            Assert.IsFalse(LikbentArray.isEquilateral());
        }
        [TestMethod]
        public void OlikArrayScalene()
        {
            double[] olikDouble = new double[3] { 3, 4, 5 };
            Triangle OlikArray = new Triangle(olikDouble);
            Assert.IsTrue(OlikArray.isScalene());
        }
        [TestMethod]
        public void OlikArrayIsosceles()
        {
            double[] olikDouble = new double[3] { 3, 4, 5 };
            Triangle OlikArray = new Triangle(olikDouble);
            Assert.IsFalse(OlikArray.isIsosceles());
        }
        [TestMethod]
        public void OlikArrayEquilateral()
        {
            double[] olikDouble = new double[3] { 3, 4, 5 };
            Triangle OlikArray = new Triangle(olikDouble);
            Assert.IsFalse(OlikArray.isEquilateral());
        }
        [TestMethod]
        public void LiksidigArrayScalene()
        {
            double[] liksidigDouble = new double[3] { 4, 4, 4 };
            Triangle LiksidigArray = new Triangle(liksidigDouble);
            Assert.IsFalse(LiksidigArray.isScalene());
        }
        [TestMethod]
        public void LiksidigArrayIsosceles()
        {
            double[] liksidigDouble = new double[3] { 4, 4, 4 };
            Triangle LiksidigArray = new Triangle(liksidigDouble);
            Assert.IsFalse(LiksidigArray.isIsosceles());
        }
        [TestMethod]
        public void LiksidigArrayEquilateral()
        {
            double[] liksidigDouble = new double[3] { 4, 4, 4 };
            Triangle LiksidigArray = new Triangle(liksidigDouble);
            Assert.IsTrue(LiksidigArray.isEquilateral());
        }

        [TestMethod]
        public void ArrayMedTreLikaObjektScalene()
        {
            Point pointLik = new Point(1, 1);

            Point[] pointsLika = new Point[3] { pointLik, pointLik, pointLik };

            Triangle ArrayMedTreLikaObjekt = new Triangle(pointsLika);
            Assert.IsFalse(ArrayMedTreLikaObjekt.isScalene());
        }
        [TestMethod]
        public void ArrayMedTreLikaObjektIsosceles()
        {
            Point pointLik = new Point(1, 1);

            Point[] pointsLika = new Point[3] { pointLik, pointLik, pointLik };

            Triangle ArrayMedTreLikaObjekt = new Triangle(pointsLika);
            Assert.IsFalse(ArrayMedTreLikaObjekt.isIsosceles());
        }
        [TestMethod]
        public void ArrayMedTreLikaObjektEquilateral()
        {
            Point pointLik = new Point(1, 1);

            Point[] pointsLika = new Point[3] { pointLik, pointLik, pointLik };

            Triangle ArrayMedTreLikaObjekt = new Triangle(pointsLika);
            Assert.IsTrue(ArrayMedTreLikaObjekt.isEquilateral());
        }
        [TestMethod]
        public void ArrayMedTreObjektTvaOlikaScalene()
        {
            Point pointLik = new Point(1, 1);
            Point pointOlik = new Point(1, 2);

            Point[] pointOlika = new Point[3] { pointLik, pointOlik, pointOlik };

            Triangle ArrayMedTreObjektTvaOlika = new Triangle(pointOlika);
            Assert.IsFalse(ArrayMedTreObjektTvaOlika.isScalene());
        }
        [TestMethod]
        public void ArrayMedTreObjektTvaOlikaIsosceles()
        {
            Point pointLik = new Point(1, 1);
            Point pointOlik = new Point(1, 2);

            Point[] pointOlika = new Point[3] { pointLik, pointOlik, pointOlik };

            Triangle ArrayMedTreObjektTvaOlika = new Triangle(pointOlika);
            Assert.IsTrue(ArrayMedTreObjektTvaOlika.isIsosceles());
        }
        [TestMethod]
        public void ArrayMedTreObjektTvaOlikaEquilateral()
        {
            Point pointLik = new Point(1, 1);
            Point pointOlik = new Point(1, 2);

            Point[] pointOlika = new Point[3] { pointLik, pointOlik, pointOlik };

            Triangle ArrayMedTreObjektTvaOlika = new Triangle(pointOlika);
            Assert.IsFalse(ArrayMedTreObjektTvaOlika.isEquilateral());
        }
        [TestMethod]
        public void ArrayMedTreOlikaObjektScalene()
        {
            Point pointLik = new Point(1, 1);
            Point pointOlik = new Point(1, 2);
            Point pointLikAlt = new Point(2, 2);

            Point[] pointOlika = new Point[3] { pointLik, pointOlik, pointLikAlt };

            Triangle ArrayMedTreOlikaObjekt = new Triangle(pointOlika);
            Assert.IsTrue(ArrayMedTreOlikaObjekt.isScalene());
        }
        [TestMethod]
        public void ArrayMedTreOlikaObjektIsosceles()
        {
            Point pointLik = new Point(1, 1);
            Point pointOlik = new Point(1, 2);
            Point pointLikAlt = new Point(2, 2);

            Point[] pointOlika = new Point[3] { pointLik, pointOlik, pointLikAlt };

            Triangle ArrayMedTreOlikaObjekt = new Triangle(pointOlika);
            Assert.IsFalse(ArrayMedTreOlikaObjekt.isIsosceles());
        }
        [TestMethod]
        public void ArrayMedTreOlikaObjektEquilateral()
        {
            Point pointLik = new Point(1, 1);
            Point pointOlik = new Point(1, 2);
            Point pointLikAlt = new Point(2, 2);

            Point[] pointOlika = new Point[3] { pointLik, pointOlik, pointLikAlt };

            Triangle ArrayMedTreOlikaObjekt = new Triangle(pointOlika);
            Assert.IsFalse(ArrayMedTreOlikaObjekt.isEquilateral());
        }

        [TestMethod]
        public void TreLikaObjektScalene()
        {
            Point pointLik = new Point(1, 1);
            Triangle TreLikaObjekt = new Triangle(pointLik, pointLik, pointLik);
            Assert.IsFalse(TreLikaObjekt.isScalene());
        }
        [TestMethod]
        public void TreLikaObjektIsosceles()
        {
            Point pointLik = new Point(1, 1);
            Triangle TreLikaObjekt = new Triangle(pointLik, pointLik, pointLik);
            Assert.IsFalse(TreLikaObjekt.isIsosceles());
        }
        [TestMethod]
        public void TreLikaObjektEquilateral()
        {
            Point pointLik = new Point(1, 1);
            Triangle TreLikaObjekt = new Triangle(pointLik, pointLik, pointLik);
            Assert.IsTrue(TreLikaObjekt.isEquilateral());
        }
        [TestMethod]
        public void TreObjektTvaOlikaScalene()
        {
            Point pointLik = new Point(1, 1);
            Point pointOlik = new Point(1, 2);
            Triangle TreObjektTvaOlika = new Triangle(pointLik, pointLik, pointOlik);
            Assert.IsFalse(TreObjektTvaOlika.isScalene());
        }
        [TestMethod]
        public void TreObjektTvaOlikaIsosceles()
        {
            Point pointLik = new Point(1, 1);
            Point pointOlik = new Point(1, 2);
            Triangle TreObjektTvaOlika = new Triangle(pointLik, pointLik, pointOlik);
            Assert.IsTrue(TreObjektTvaOlika.isIsosceles());
        }
        [TestMethod]
        public void TreObjektTvaOlikaEquilateral()
        {
            Point pointLik = new Point(1, 1);
            Point pointOlik = new Point(1, 2);
            Triangle TreObjektTvaOlika = new Triangle(pointLik, pointLik, pointOlik);
            Assert.IsFalse(TreObjektTvaOlika.isEquilateral());
        }
    }
}
