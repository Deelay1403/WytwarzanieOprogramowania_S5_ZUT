using NUnit.Framework;

namespace WytwarzanieOprogramowaniaTest
{
    public class CalcTest
    {
        [SetUp]
        public void Setup()
        {
            Calc calc = new Calc();
        }

        [Test]
        public void AddTest()
        {
            Assert.Pass();
        }
    }
}