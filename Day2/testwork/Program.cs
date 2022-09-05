using System;

namespace testwork
{
    class Program
    {
        static void Main(string[] args)
        {
            //定义四个变量，分别存储一个人的姓名、性别、年龄、电话
            Console.WriteLine("Hello World!");
            string Name;
            char Gerder;
            int Age;
            string Telephonenumber;
            Name = "huangshuo";
            Gerder = '男';
            Age = 23;
            Telephonenumber = 225880;

            Console.WriteLine("我叫{0}，我今年{1}岁了，我是{2}生，我的电话号码是{3}", Name,Age, Gerder, Telephonenumber);
            Console.ReadKey();
        }
    }
}
