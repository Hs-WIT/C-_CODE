using System;

namespace 随机数
{
    class Program
    {
        static void Main(string[] args)
        {
            //产生随机数
            //1、创建能够产生随机数的对象
            Random r = new Random();
            while(true)
            {
                //2.让产生随机数的这个对象调用方法来产生随机数
                int rNumber = r.Next(1, 11);
                Console.WriteLine(rNumber);

            }
        }
    }
}
