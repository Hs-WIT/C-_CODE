using System;

namespace 乘法口诀
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=9;i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}*{1}={2}\t",j,i,i*j);
                }
                Console.WriteLine();
            }
        }
    }
}
