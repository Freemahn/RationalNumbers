using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RationalNumbers;
namespace RationalNumbersTest
{
    [TestClass]
    public class RationalNumbersTest
    {
        [TestMethod]
        public void ReduceFraction()
        {
            Rational r1 = new Rational(2, 5);
            Rational r2 = new Rational(100, 250);
            Assert.AreEqual(Rational.Normalize(r2).ToDouble(), r1.ToDouble(), 0.001, "Add not worked correctly");
        }

        [TestMethod]
        public void Add()
        {
            double d1 = 3/2.0;
            double d2 = 1/125.0;
            double expected = d1 + d2; 
            Rational r1 = new Rational(3, 2);
            Rational r2 = new Rational(1, 125);
            double actual = (r1 + r2).ToDouble();
            Assert.AreEqual(expected, actual, 0.001, "Add doesnt work correctly");
        }

        [TestMethod]
        public void Substract()
        {
            double d1 =3/2.0;
            double d2 = 1/125.0;
            double expected = d1 - d2;
            Rational r1 = new Rational(3, 2);
            Rational r2 = new Rational(1, 125);
            double actual = (r1 - r2).ToDouble();
            Assert.AreEqual(expected, actual, 0.001, "Substract doesnt  work correctly");
        }
        [TestMethod]
        public void Multiply()
        {
            double d1 = 3 / 2.0;
            double d2 = 1 / 125.0;
            double expected = d1 * d2;
            Rational r1 = new Rational(3, 2);
            Rational r2 = new Rational(1, 125);
            double actual = (r1 * r2).ToDouble();
            Assert.AreEqual(expected, actual, 0.001, "Substract doesnt  work correctly");
        }
        [TestMethod]
        public void Divide()
        {
            double d1 = 3 / 2.0;
            double d2 = 1 / 125.0;
            double expected = d1 / d2;
            Rational r1 = new Rational(3, 2);
            Rational r2 = new Rational(1, 125);
            double actual = (r1 / r2).ToDouble();
            Assert.AreEqual(expected, actual, 0.001, "Substract doesnt  work correctly");
        }
    }
}
