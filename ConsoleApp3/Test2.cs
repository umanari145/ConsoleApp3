using ConsoleApp3.Util;

namespace ConsoleApp3;

[TestClass]
public class Test2
{

    [TestMethod]
    public void TestMethod1()
    {
        CollectionSample cs = new CollectionSample();
        cs.collectionSample();
        cs.dateSample();
    }


    [TestMethod]
    public void TestMethod2()
    {
        CollectionSample2 cs2 = new CollectionSample2();
        cs2.printout();
    }

    [TestMethod]
    public void TestMethod3()
    {
        CollectionSample3 cs3 = new CollectionSample3();
        cs3.collectionOutput();
    }

    [TestMethod]
    public void TestMethod4()
    {
        CollectionSample4 cs4 = new CollectionSample4();
        cs4.output();
    }

    [TestMethod]
    public void TestMethod5()
    {
        CollectionSample5 cs5 = new CollectionSample5();
        cs5.output();
    }

    [TestMethod]
    public void TestMethod6()
    {
        CollectionSample6 cs6 = new CollectionSample6();
        cs6.output();
    }


    [TestMethod]
    public void TestMethod7()
    {
        CollectionSample7 cs7 = new CollectionSample7();
        cs7.output();
    }

    [TestMethod]
    public void TestMethod8()
    {
        CollectionSample8 cs8 = new CollectionSample8();
        cs8.outputter();
    }

    [TestMethod]
    public void TestMethod9()
    {
        CollectionSample9 cs9 = new CollectionSample9();
        cs9.output();
    }

    [TestMethod]
    public void TestMethod10()
    {
        CollectionSample10 cs10 = new CollectionSample10();

        cs10.output();
    }


    [TestMethod]
    public void TestMethod11()
    {
        CollectionSample11 cs11 = new CollectionSample11();

        cs11.output();
    }


    [TestMethod]
    public void TestMethod12()
    {
        CollectionSample12 cs12 = new CollectionSample12();

        cs12.output();
    }
}
