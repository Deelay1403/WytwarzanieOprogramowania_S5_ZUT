using Microsoft.VisualStudio.TestTools.UnitTesting;
using WytwarzanieOprogramowania;

namespace CalcTest
{
    [TestClass]
    public class CalcTest
    {
        //private Calc calc = new Calc();
        [TestMethod]
        public void addTest()
        {
            Assert.AreEqual(4, Calc.Add(2, 2));
            Assert.AreEqual(0, Calc.Add(-10, 10));
            Assert.AreEqual(-1, Calc.Add(long.MaxValue, long.MinValue));
        }
        [TestMethod]
        public void subTest()
        {
            Assert.AreEqual(0, Calc.Sub(2, 2));
            Assert.AreEqual(-20, Calc.Sub(-10, 10));
            Assert.AreEqual(-1, Calc.Sub(long.MaxValue, long.MinValue));

        }
        [TestMethod]
        public void multiplyTest()
        {
            Assert.AreEqual(4, Calc.Multiply(2, 2));
            Assert.AreEqual(-4, Calc.Multiply(-2, 2));
            Assert.AreEqual(long.MinValue, Calc.Multiply(long.MaxValue, long.MinValue));
        }
        [TestMethod]
        public void decToBinTest()
        {
            Assert.AreEqual("100", Calc.convert(4,2));
            Assert.AreEqual("1111111111111111111111111111111111111111111111111111111111111111", 
                Calc.convert((long)-1,2));
            Assert.AreEqual("11111111111111111111111111111111",
                Calc.convert(-1,2));
            Assert.AreEqual("1111111111111111",
                Calc.convert((short)-1,2));
            Assert.AreEqual("11111111",
                Calc.convert((sbyte)-1,2));
        }
        [TestMethod]
        public void decToOktTest()
        {
            Assert.AreEqual("10", Calc.convert(8,8));
            Assert.AreEqual("1777777777777777777777",
                Calc.convert((long)-1,8));
            Assert.AreEqual("37777777777",
                Calc.convert(-1,8));
            Assert.AreEqual("177777",
                Calc.convert((short)-1,8));
            Assert.AreEqual("377",
                Calc.convert((sbyte)-1,8));
        }
        [TestMethod]
        public void decToHexTest()
        {
            Assert.AreEqual("F".ToLower(), Calc.convert(15, 16));
            Assert.AreEqual("FFFFFFFFFFFFFFFF".ToLower(),
                Calc.convert((long)-1, 16));
            Assert.AreEqual("FFFFFFFF".ToLower(),
                Calc.convert(-1, 16));
            Assert.AreEqual("FFFF".ToLower(),
                Calc.convert((short)-1, 16));
            Assert.AreEqual("FF".ToLower(),
                Calc.convert((sbyte)-1, 16));
        }
        [TestMethod]
        public void orTest() 
        {
            Assert.AreEqual(-1, Calc.OR(0, -1));
            Assert.AreEqual(-1, Calc.OR(int.MinValue, int.MaxValue));
        }
        [TestMethod]
        public void andTest()
        {
            Assert.AreEqual(0, Calc.AND(0, -1));
            Assert.AreEqual(0, Calc.AND(int.MinValue, int.MaxValue));
        }
        [TestMethod]
        public void xorTest()
        {
            Assert.AreEqual(-1, Calc.XOR(0, -1));
            Assert.AreEqual(-1, Calc.XOR(int.MinValue, int.MaxValue));
        }
        [TestMethod]
        public void notTest()
        {
            Assert.AreEqual(-1, Calc.NOT(0));
            Assert.AreEqual(int.MinValue, Calc.NOT(int.MaxValue));
        }
        [TestMethod]
        public void lshTest()
        {
            Assert.AreEqual(0, Calc.Lsh(int.MinValue, 1));
            Assert.AreEqual(-2, Calc.Lsh(int.MaxValue, 1));
        }
        [TestMethod]
        public void rshTest()
        {
            Assert.AreEqual(0, Calc.Rsh(1, 1));
            Assert.AreEqual(1073741823, Calc.Rsh(int.MaxValue, 1));
        }
        [TestMethod]
        public void plusMinusTest()
        {
            Assert.AreEqual(1, Calc.PlusMinus(-1));
            Assert.AreEqual(-1*int.MaxValue, Calc.PlusMinus(int.MaxValue));
        }
        [TestMethod]
        public void moduloTest()
        {
            Assert.AreEqual(0, Calc.Modulo(int.MaxValue, -1));
            Assert.AreEqual(-1, Calc.Modulo(int.MinValue, int.MaxValue));
        }
        [TestMethod]
        public void rolTest()
        {
            Assert.AreEqual(0, Calc.Rol(int.MinValue));
            Assert.AreEqual(-2, Calc.Rol(int.MaxValue));
        }
        [TestMethod]
        public void rorTest()
        {
            Assert.AreEqual(0, Calc.Ror(1));
            Assert.AreEqual(1073741823, Calc.Ror(int.MaxValue));
        }
        [TestMethod]
        public void CEtest()
        {
            Assert.AreEqual("0", Calc.CE());
        }
        [TestMethod]
        public void byteTest()
        {

            Assert.AreEqual(-1, Calc.Byte(long.MaxValue));
            Assert.AreEqual(0, Calc.Byte(long.MinValue));
            Assert.AreEqual(0, Calc.Byte(int.MinValue));
            Assert.AreEqual(sbyte.MaxValue, Calc.Byte(sbyte.MaxValue));
        }
        [TestMethod]
        public void wordTest()
        {

            Assert.AreEqual(-1, Calc.Word(long.MaxValue));
            Assert.AreEqual(0, Calc.Word(long.MinValue));
            Assert.AreEqual(0, Calc.Word(int.MinValue));
            Assert.AreEqual(short.MaxValue, Calc.Word(short.MaxValue));
        }
        [TestMethod]
        public void dwordTest()
        {

            Assert.AreEqual(-1, Calc.DWord(long.MaxValue));
            Assert.AreEqual(0, Calc.DWord(long.MinValue));
            Assert.AreEqual(int.MinValue, Calc.DWord(int.MinValue));
        }
        [TestMethod]
        public void qwordTest()
        {

            Assert.AreEqual(long.MaxValue, Calc.QWord(long.MaxValue));
            Assert.AreEqual(long.MinValue, Calc.QWord(long.MinValue));
            Assert.AreEqual(int.MinValue, Calc.QWord(int.MinValue));
        }
        [TestMethod]
        public void CTest()
        {
            Assert.AreEqual(0, Calc.C());
        }
    }
}
