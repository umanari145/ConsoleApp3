using ConsoleApp3.Entity;
using ConsoleApp3.Util;

namespace ConsoleApp3;

[TestClass]
public class Test1
{
    [TestMethod]
    public void TestMethod1()
    {
        var calc = new Caluculator();

        int result = calc.Sum(1, 2);

        Assert.AreEqual(3, result);
    }


    [TestMethod]
    public void TestMethod2()
    {
        CollectionSample12  cs12 = new CollectionSample12();

        cs12.output();

    }
}
