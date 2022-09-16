using System;

namespace 计算平均年龄
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习1:循环录入5个人的年龄并计算平均年龄,
            //如果录入的数据出现负数或大于100的数,立即停止输入并报错.
            int sum = 0;
            bool b = true;
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("请输入第{0}个人的年龄", i);
                try
                {
                    int age = Convert.ToInt32(Console.ReadLine());
                    if (age >= 0 && age <= 100)
                    {
                        sum += age;
                    }
                    else
                    {
                        Console.WriteLine("年龄范围不正确，程序退出");
                        b = false;
                        break;
                    }
                }
                catch 
                {
                    Console.WriteLine("年龄格式不正确，程序退出");
                    b = false;
                    break;
                }
                
            }
            if (b)
            {
                Console.WriteLine("avg age is{0}", sum / 5);
            }
        }
    }
}
