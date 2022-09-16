


using System;

namespace _ref参数
{
    class Program
    {
        public static void jiangjin(double s)
        {
            s += 500;
        }
        public static void jiangjin2(ref double s)
        {
            s += 500;
        }
        static void Main(string[] args)
        {
            double salary = 5000;
            jiangjin(salary);
            Console.WriteLine(salary);

            double salary2 = 4000;
            jiangjin2(ref salary2);
            Console.WriteLine(salary2);
        }
    }
}
