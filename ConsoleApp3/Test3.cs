using ConsoleApp3.Entity;
using ConsoleApp3.Util;

namespace ConsoleApp3;

[TestClass]
public class Test3
{
    [TestMethod]
    public void TestMethod1()
    {
        NullLearnClass nc = new NullLearnClass();
        nc.output();
    }

    [TestMethod]
    public void TestMethod2()
    {
        RegexSample rs = new RegexSample();
        rs.judgemenet();
        rs.filtering();
        rs.replace();
    }


    [TestMethod]
    public void TestMethod3()
    {
        Cat cat = new Cat("たま");
        cat.MakeSound();
    }


    [TestMethod]
    public void TestMethod4()
    {
        Entity.Dog dog = new Entity.Dog("ポチ");
        dog.MakeSound();
    }

    [TestMethod]
    public void TestMethod5()
    {
        Instrument guitar = new Guitar("スーパーギター", 30000, 4);
        guitar.showInfo();
        guitar.Play();
        
    }


    [TestMethod]
    public void TestMethod6()
    {
        Instrument piano = new Piano("スーパーピアノ", 30000);
        piano.showInfo();
        piano.Play();

    }


    [TestMethod]
    public void TestMethod7()
    {
        Reflection rf = new Reflection();
        rf.reflection();

    }
    
    [TestMethod]
    public void TestMethod8()
    {
        Vehicle car = new Car("フェラーリ",150,2);
        car.showInfo();
        car.Move();

        AirPlane airplane = new AirPlane("ボーイング", 900, 15000);
        airplane.showInfo();
        airplane.Move();


    }


}
