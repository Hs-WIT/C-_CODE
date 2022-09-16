using System;

namespace 水仙花
{
    class Program
    {
        static void Main(string[] args)
        {
            //找出100-999间的水仙花数?
            //水仙花数指的就是 这个百位数字的
            //百位的立方+十位的立方+个位的立方==当前这个百位数字
            
            for(int i=100;i<=999;i++)
            {
                int hundred = i / 100;
                int decade = i % 100 / 10;
                int unit = i % 10;
                if (hundred*hundred*hundred+decade*decade*decade+unit*unit*unit==i)
                {
                    Console.WriteLine("100-999之间的水仙花数有{0}",i);
                }

            }
        }
    }
}
