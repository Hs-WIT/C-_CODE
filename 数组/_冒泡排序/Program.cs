

using System;

namespace _冒泡排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 5, 6, 3, 6, 7, 2, 8, 11, 9 ,78124};
            //Array.Sort(nums);
            //Array.Reverse(nums);
            for (int i = 0; i < nums.Length-1; i++)
            {
                for (int j = 0; j < nums.Length-1-i; j++)
                {
                    if (nums[j]<nums[j+1])
                    {
                        int tmp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = tmp;
                    }
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
