using Microsoft.VisualStudio.TestTools.UnitTesting;
using LAB3;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            RomanNumber q = new RomanNumber(9);
            RomanNumber q1 = new RomanNumber(14);
            RomanNumber q2 = new RomanNumber(37);
            RomanNumber q3 = new RomanNumber(84);
            RomanNumber q4 = new RomanNumber(228);
            RomanNumber q5 = new RomanNumber(1337);
            Assert.AreEqual("IX", q.ToString());
            Assert.AreEqual("XIV", q1.ToString());
            Assert.AreEqual("XXXVII", q2.ToString());
            Assert.AreEqual("LXXXIV", q3.ToString());
            Assert.AreEqual("CCXXVIII", q4.ToString());
            Assert.AreEqual("MCCCXXXVII", q5.ToString());
        }

        [TestMethod]
        public void TestMetod2()
        {
            try
            {
                var a = new RomanNumber(1);
            }
            catch (RomanNumberException exception)
            {
                Assert.Fail(exception.Message);
            }
        }

        [TestMethod]
        public void TestMetod3()
        {
            try
            {
                var b = new RomanNumber(3999);
            }
            catch (RomanNumberException exception)
            {
                Assert.Fail(exception.Message);
            }
        }

        [TestMethod]
        public void TestMetod4()
        {
            try
            {
                var c = new RomanNumber(0);
                Assert.Fail("Error: неверное входное значение");
            }
            catch 
            {
            }

            try
            {
                var d = new RomanNumber(5555);
                Assert.Fail("Error: неверное входное значение");
            }
            catch
            {
            }
        }

        [TestMethod]
        public void TestMetod5()
        {
            var a = new RomanNumber(5);
            var b = new RomanNumber(7);
            Assert.AreEqual("XII", (a+b).ToString());
        }

        [TestMethod]
        public void TestMetod6()
        {

            var a = new RomanNumber(5);
            var b = new RomanNumber(7);
            Assert.AreEqual("II", (b - a).ToString());
        }

        [TestMethod]
        public void TestMetod7()
        {

            var a = new RomanNumber(10);
            var b = new RomanNumber(5);
            Assert.AreEqual("II", (a/b).ToString());
        }

        [TestMethod]
        public void TestMetod8()
        {
            var a = new RomanNumber(5);
            var b = new RomanNumber(7);
            Assert.AreEqual("XXXV", (a*b).ToString());
        }

        [TestMethod]
        public void TestMetod9()
        {
            var a = new RomanNumber(5);
            var b = new RomanNumber(7);

            var p = (RomanNumber)a.Clone();

            Assert.AreEqual(a.ToString(), p.ToString());
            a = b;
            Assert.AreNotEqual(a.ToString(), p.ToString());
        }

        [TestMethod]
        public void TestMetod10()
        {
            var a = new RomanNumber(5);
            var b = new RomanNumber(5);

            Assert.AreEqual(0, a.CompareTo(b));
            a += b;
            Assert.AreEqual(5, a.CompareTo(b));
        }

    }
}