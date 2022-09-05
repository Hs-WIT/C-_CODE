using System;

namespace _交换变量
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            int n2 = 20;
            int tmp;
            Console.WriteLine("Hello World!");
             tmp = n1;
             n1 = n2;
             n2 = tmp;
            Console.WriteLine("n1 is {0},n2 is {1}", n1, n2);

            //要求不使用第三方变量
            int n3 = 50;
            int n4 = 30;
            n3 = n3 - n4;
            n4 = n4 + n3;
            n3 = n4 - n3;
            Console.WriteLine("n3 is {0},n4 is {1}",n3,n4);
            Console.ReadKey();

        }
    }
}
