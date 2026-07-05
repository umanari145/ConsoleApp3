
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
            CollectionSample cs = new CollectionSample();
            cs.collectionSample();
        }
    }
}