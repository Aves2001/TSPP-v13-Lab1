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

            double result = Lab1.Program.CubeRibArea(a); //�������� ���[V] ���� �� ������ ���� �����[a]
            Assert.AreEqual(64, result);

            result = Lab1.Program.SurfaceAreaCube(a); //�������� �����[S] ������� ���� �� ������ ���� �����[a]
            Assert.AreEqual(96, result);
        }
    }
}
