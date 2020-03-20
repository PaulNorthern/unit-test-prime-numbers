using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hello_world;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(false, PrimeService.IsPrimeNumber(100));        
            //Assert.AreEqual(true, PrimeService.IsPrimeNumber(19));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(true, PrimeService.IsPrimeNumber(5));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(true, PrimeService.IsPrimeNumber(19));
        }

        [DataTestMethod]
        [DataRow(2, true)]
        [DataRow(3, true)]
        [DataRow(100, false)]
        [DataRow(23657, false)]
        [DataRow(7, true)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value, bool result)
        {
            Assert.AreEqual(result, PrimeService.IsPrimeNumber(value));
        }
    }
}
