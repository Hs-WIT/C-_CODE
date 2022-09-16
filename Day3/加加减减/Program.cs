using System;

namespace 加加减减
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            int result1 = 10 + number++;
            int result2 = 10 + (++number);
            Console.WriteLine(result1);
            Console.WriteLine(result2);

            int a = 5;
            int b = a++ + ++a * 2 + --a + a++;
            //      5+7*2+6+6
            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}
