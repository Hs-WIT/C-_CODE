using System;

namespace 素数
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 2; i <= 100; i++)
            {
                bool b = true;
                for (int j=2;j<i;j++)
                {
                    if (i%j==0)
                    {
                        b = false;
                        break;
                    }
                }
                if (b)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
