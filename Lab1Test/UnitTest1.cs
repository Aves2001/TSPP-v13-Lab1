using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab1Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double a = 4;

            double result = Lab1.Program.CubeRibArea(a); //Обчислює обєм[V] куба по довжині його ребра[a]
            Assert.AreEqual(64, result);

            result = Lab1.Program.SurfaceAreaCube(a); //Обчислює площю[S] поверхні куба по довжині його ребра[a]
            Assert.AreEqual(96, result);
        }
    }
}
