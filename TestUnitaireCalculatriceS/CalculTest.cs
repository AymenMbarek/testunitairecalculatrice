using NUnit.Framework;
using System;

namespace Calculatrice
{
    [TestFixture]
    public class CalculTest
    {
        private CalculeSimple cal;
       
        [SetUp]
        public void SetUp()
        {
        }
       

        //addition tests
        [Test]
        [TestCase(50, 50, 100)]
        [TestCase(1, 1, 2)]
        [TestCase(0, 0, 0)]
        [TestCase(5000, 5000, 10000)]
        public void AdditionTest(double n1, double n2, double awaitedresult)
        {
            cal = new CalculeSimple();

            var result = cal.Addition(n1,n2);
            
            Assert.AreEqual(result,awaitedresult);
        }
        [TestCase(double.MinValue, -1)]
        [TestCase(double.MaxValue, 0)]
        [TestCase(double.MaxValue, 1)]
        [TestCase(double.MaxValue, double.MaxValue)]
        [TestCase(double.MinValue, -1)]
        [TestCase(double.MinValue, 1)]
        [TestCase(double.MinValue, double.MinValue)]
        public void AdditionTest_limit(double n1, double n2)
        {
          cal = new CalculeSimple();
         var result= Assert.Throws<ArgumentException>(() => cal.Addition(n1, n2));

           Assert.IsNotNull(result) ;
        }
        //substration test
        [Test]
        [TestCase(50, 50, 0)]
        [TestCase(1, 1, 0)]
        [TestCase(0, 5, -5)]
        [TestCase(6000, 5000, 1000)]
        public void SubtractionTest(double n1, double n2, double awaitedresult)
        {
            cal = new CalculeSimple();

            var result = cal.Substraction(n1, n2);

            Assert.AreEqual(result, awaitedresult);
        }
        [TestCase(double.MinValue, -1)]
        [TestCase(double.MinValue, 1)]
        [TestCase(double.MinValue, double.MinValue)]
        [TestCase(double.MinValue, -1)]
        [TestCase(double.MinValue, 1)]
        [TestCase(double.MinValue, double.MinValue)]
        public void SubtractionTest_limit(double n1, double n2)
        {
            cal = new CalculeSimple();
            var result = Assert.Throws<ArgumentException>(() => cal.Substraction(n1, n2));

            Assert.IsNotNull(result);
        }

        //multiplication test
        [Test]
        [TestCase(50, 50, 2500)]
        [TestCase(1, 1, 1)]
        [TestCase(0, 5, 0)]
        [TestCase(6000, 2, 12000)]
        public void MulitiplicationTest(double n1, double n2, double awaitedresult)
        {
            cal = new CalculeSimple();

            var result = cal.Mulitiplication(n1, n2);

            Assert.AreEqual(result, awaitedresult);
        }
        [TestCase(double.MinValue, -1)]
        [TestCase(double.MinValue, 1)]
        [TestCase(double.MinValue, double.MinValue)]
        [TestCase(double.MinValue, -1)]
        [TestCase(double.MinValue, 1)]
        [TestCase(double.MinValue, double.MinValue)]
        public void MulitiplicationTest_limit(double n1, double n2)
        {
            cal = new CalculeSimple();
            var result = Assert.Throws<ArgumentException>(() => cal.Mulitiplication(n1, n2));

            Assert.IsNotNull(result);
        }
        //division test
        [Test]
        [TestCase(50, 50, 1)]
        [TestCase(1, 1, 1)]
        [TestCase(0, 5, 0)]
        [TestCase(6000, 2, 3000)]
        public void DivisionTest(double n1, double n2, double awaitedresult)
        {
            cal = new CalculeSimple();

            var result = cal.Division(n1, n2);

            Assert.AreEqual(result, awaitedresult);
        }

        [TestCase(double.MinValue, -1)]
        [TestCase(double.MinValue, 1)]
        [TestCase(double.MinValue, double.MinValue)]
        [TestCase(double.MinValue, -1)]
        [TestCase(double.MinValue, 1)]
        [TestCase(double.MinValue, double.MinValue)]
        public void DivisionTest_limit(double n1, double n2)
        {
            cal = new CalculeSimple();
            var result = Assert.Throws<ArgumentException>(() => cal.Division(n1, n2));

            Assert.IsNotNull(result);
        }
        [TestCase(1,0)]
        public void DivisionTest_DivisionByZero(double n1, double n2)
        {
            cal = new CalculeSimple();
            var result = Assert.Throws<DivideByZeroException>(() => cal.Division(n1, n2));

            Assert.IsNotNull(result);
        }
    }
}