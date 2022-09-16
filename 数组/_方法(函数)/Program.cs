using System;

namespace _方法_函数_
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int max = Program.GetMax(1, 3);
            Console.WriteLine(max);
        }
        /// <summary>
       /// 计算两个整数之间的最大值并且将最大值返回
       /// </summary>
         /// <param name="n1">第一个整数</param>
        /// <param name="n2">第二个整数</param>
       /// <returns>将最大值返回</returns>
         public static int GetMax(int n1, int n2)
         {
            return n1 > n2? n1 : n2;
         }
}
}
