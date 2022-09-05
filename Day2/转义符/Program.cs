using System;

namespace 转义符
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = "zhangshan";
            string name2 = "wnagwu ";
            string name3 = "liushishi";
            string name4 = "jingtianshangzi";
            Console.WriteLine("Hello World!");
            Console.WriteLine("今天天气好晴朗\n处处好风光");
            Console.WriteLine("输出一个\"\"英文半角符");
            Console.WriteLine("{0}\t{1}", name1, name2);
            Console.WriteLine("{0}\t{1}", name3, name4);
            Console.WriteLine("今天天气好晴朗\b处处好风光");
            Console.WriteLine("\b今天天气好晴朗处处好风光");
            Console.WriteLine("今天天气好晴朗处处好风光\b");

            string str = "今天天气好晴朗\r\n处处好风光";
            System.IO.File.WriteAllText(@"D:\Users\ahuang\Desktop\c#_test.txt",str);
            Console.WriteLine(@"今天天气好晴朗
             处处好风光");
            Console.WriteLine("写入成功！");
            Console.ReadKey();
            char c = '\b';
        }
    }
}
