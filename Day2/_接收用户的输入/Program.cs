

using System;

namespace _接收用户的输入
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("请输入你的姓名、年龄、性别"); 
            string name = Console.ReadLine();
            string age = Console.ReadLine();
            string gender = Console.ReadLine();
            Console.WriteLine("您的姓名是{0}，年龄是{1}，{2}生", name,age,gender);
            Console.ReadKey();
        }
    }
}