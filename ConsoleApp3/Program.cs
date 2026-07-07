
using ConsoleApp3.Entity;
using ConsoleApp3.Util;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileUtil fileUtil = new FileUtil();
            //fileUtil.fileGetContents();
            //fileUtil.UserInfo();
            //fileUtil.getProductInfo();
            //CollectionSample cs = new CollectionSample();
            //cs.collectionSample();
            //cs.dateSample();



            Person person = new Person();
            person.Name = "John";
            person.Age = 30;

            person.introduce();

            BankAcount bankAcount = new BankAcount();
            bankAcount.Deposit(1000);
            bankAcount.withdraw(1500);


            Cat cat = new Cat("タマ");
            cat.MakeSound();
            Dog dog = new Dog("ポチ");
            dog.MakeSound();


            Circle circle = new Circle();
            Console.WriteLine(circle.CalculateArea(5));

            Counter counter = new Counter();
            Counter counter2 = new Counter();
            Counter counter3 = new Counter();
            Console.WriteLine($"Counter: {Counter.Count}");
        }
    }
}