using ConsoleApp3;
using ConsoleApp3.Entity;
using ConsoleApp3.Util;

namespace TestProject2
{
    [TestClass]
    public sealed class Test2
    {
        [TestMethod]
        public void TestMethod1()
        {
            Guitar guitar = new Guitar("Yamaha", 10000, 6);
            guitar.Play();
            guitar.ITune();
        }

        [TestMethod]
        public void TestMethod2()
        {
            Piano piano = new Piano("Steinway", 50000);
            piano.Play();
        }

        [TestMethod]
        public void TestMethod3()
        {
            ConsoleApp3.Utilss.RegexSample rs = new ConsoleApp3.Utilss.RegexSample();
            rs.judgemenet();
            rs.filtering();
            rs.replace();
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

        [TestMethod]
        public void TestMethod7()
        {
            CollectionSample7 sample7 = new CollectionSample7();
            sample7.output();
        }


        [TestMethod]
        public void TestMethod8()
        {
            CollectionSample8 sample8 = new CollectionSample8();
            sample8.outputter();
        }

        [TestMethod]
        public void TestMethod9()
        {
            CollectionSample9 sample9 = new CollectionSample9();
            sample9.output();
        }
    }
}
