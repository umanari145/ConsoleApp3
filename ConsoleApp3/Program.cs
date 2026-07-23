
using System.Runtime.CompilerServices;
using ConsoleApp3.Entity;
using ConsoleApp3.Service;
using ConsoleApp3.Util;
using Dog = ConsoleApp3.Util.Dog;

namespace ConsoleApp3
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //Scraper scraper = new Scraper();
            //var words = await scraper.getWord();
            //DBUtil dbutil = new DBUtil();
            //dbutil.ConnectToDatabase();
            //dbutil.Insert()


            //FileUtil fileUtil = new FileUtil();
            //fileUtil.fileGetContents();
            //fileUtil.UserInfo();
            //fileUtil.getProductInfo();
            //CollectionSample cs = new CollectionSample();
            //cs.collectionSample();
            //cs.dateSample();


            /*
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
            */

            /*Generics<int> intBox = new Generics<int>();
            intBox.set(42);
            Console.WriteLine($"Integer value: {intBox.get()}");


            Generics<string> stringBox = new Generics<string>();
            stringBox.set("Hello, Generics!");
            Console.WriteLine($"String value: {stringBox.get()}");


            AnilaShelter<Dog> anilaShelter = new AnilaShelter<Dog>();
            anilaShelter.AddAnimal(new Dog("ポチ"));
            anilaShelter.AnnnounceAnimalSound();*/

            /*RegexSample regexSample = new RegexSample();
            regexSample.judgemenet();
            regexSample.filtering();
            regexSample.replace();*/
            //CollectionSample2 sample2 = new CollectionSample2();
            //sample2.printout();
            //CollectionSample3 sample3 = new CollectionSample3();
            //sample3.collectionOutput();
            //CollectionSample4 sample4 = new CollectionSample4();
            //sample4.output();
            //CollectionSample5 sample5 = new CollectionSample5();
            //sample5.output();
            //CollectionSample6 sample6 = new CollectionSample6();
            //sample6.output();
            //CollectionSample7 sample7 = new CollectionSample7();
            //sample7.output();
            //CollectionSample8 sample8 = new CollectionSample8();
            //sample8.outputter();
            //CollectionSample10 sample10 = new CollectionSample10();
            //sample10.output();
            /*var intBox = new Box<int>(10);
            Console.WriteLine(intBox.GetValue());
            intBox.SetValue(20);
            Console.WriteLine(intBox.GetValue());

            var intBox2 = new Box<string>("Hello");
            Console.WriteLine(intBox2.GetValue());
            intBox2.SetValue("Hello2");
            Console.WriteLine(intBox2.GetValue());*/
            //Reflection reflection = new Reflection();
            //reflection.reflection();
            //CollectionSample11 collectionSample11 = new CollectionSample11();
            //collectionSample11.output();
            //Book book = new Book("吾輩は猫である", "夏目漱石", 800);
            //book.messsage();
            //enumlesson el = new enumlesson();
            //el.output();
            NullLearnClass nl = new NullLearnClass();
            nl.output();
        }
    }
}