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
        CollectionSample12 cs12 = new CollectionSample12();

        cs12.output();
    }
}
