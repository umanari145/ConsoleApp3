using ConsoleApp3.Util;

namespace TestProject2
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CollectionSample sample1 = new CollectionSample();
            sample1.collectionSample();
        }

        [TestMethod]
        public void TestMethod2()
        {
            var sample2 = new CollectionSample2();
            sample2.printout();
        }

        [TestMethod]
        public void TestMethod3()
        {
            var sample3 = new CollectionSample3();
            sample3.collectionOutput();
        }

        [TestMethod]
        public void TestMethod4()
        {
            var sample4 = new CollectionSample4();
            sample4.output();
        }

        [TestMethod]
        public void TestMethod5()
        {
            var sample5 = new CollectionSample5();
            sample5.output();
        }


        [TestMethod]
        public void TestMethod6()
        {
            var sample6 = new CollectionSample6();
            sample6.output();
        }
    }
}
