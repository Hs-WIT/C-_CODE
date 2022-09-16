using System;

namespace continue语句
{
    class Program
    {
        static void Main(string[] args)
        {
            //用 while continue实现计算1到100(含)之间的除了能被7整除之外所有整数的和。
            int sum = 0;
            int i = 1;
            while(i<=100)
            {
                if (i%7==0)
                {
                    i++;
                    continue;
                }
                sum += i;
                i++;
            }
            Console.WriteLine(sum);

            
            
        }
    }
}
