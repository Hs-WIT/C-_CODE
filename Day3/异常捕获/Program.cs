using System;

namespace 异常捕获
{
    class Program
    {
        static void Main(string[] args)
        {
            int number=0;
            bool b = true;
            Console.WriteLine("请输入一个数字");
            try 
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
           catch
            {
                Console.WriteLine("输入的内容不能转换成数字");
                b = false;
            }
            if (b==true)
            {
                Console.WriteLine(number * 2);
            }
            Console.ReadKey();
            
        }
    }
}
