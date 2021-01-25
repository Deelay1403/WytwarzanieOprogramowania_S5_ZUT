using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCalc
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Calc.Add(2, 2), 4);
        }
    }
}
