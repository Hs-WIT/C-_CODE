using System;

namespace _数组
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }

            string[] str = new string[10];
            bool[] bools = new bool[10];
        }
    }
}
