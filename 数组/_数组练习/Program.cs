
using System;

namespace _数组练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 
            ////练习1：从一个整数数组中取出最大的整数,最小整数,总和,平均值
            ////声明一个int类型的数组 并且随意的赋初值
            int[] nums = { 1, 2, 3, 4, 5, 7, 8, 9, 10 };
            //声明两个变量用来存储最大值和最小值
            int max = nums[0];
            int min = nums[0];
            int sum = 0;
            //循环的让数组中的每个元素跟最大值、最小值进行比较
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
                if (nums[i] < min)
                {
                    min = nums[i];
                }
                sum += nums[i];
            }
            Console.WriteLine("这个数组的最大值是{0}，最小值是{1}，总和是{2}，平均值是{3}", max, min, sum, sum / nums.Length);
            #endregion

            //练习：将一个字符串数组的元素的顺序进行反转。{“我”,“是”,”好人”} {“好人”,”是”,”我”}。第i个和第length-i-1个进行交换。
            string[] names = { "a","b","c","d","e","f"};
            for (int i = 0; i < names.Length/2; i++)
            {
                string tmp = names[i];
                names[i] = names[names.Length - 1 - i];
                names[names.Length - 1 - i] = tmp;
            }
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}
