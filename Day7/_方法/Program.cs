using System;

namespace _方法
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion1
            //Console.WriteLine("please write the year");
            //int Year = Convert.ToInt32(Console.ReadLine());
            //bool b = Program.IsRun(Year);
            //Console.WriteLine(b);
            #endregion

            int[] nums = { 1,2,3,4,5,6,7,324,234};
            int max1;
            int min1;
            int sum1;
            int avg1;
            bool b;
            string s;
            double d;
            Test(nums, out max1, out min1, out sum1, out avg1, out b, out s, out d);
            Console.WriteLine(max1);
            Console.WriteLine(min1);
            Console.WriteLine(sum1);
            Console.WriteLine(avg1);
            Console.WriteLine(b);
            Console.WriteLine(s);
            Console.WriteLine(d);
        }
        /// <summary>
        /// 判断给定的年份是否是闰年
        /// </summary>
        /// <param name="year">判断的年份</param>
        /// <returns>是否是闰年</returns>
        public static bool IsRun(int year)
        {
            bool b = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
            return b;
        }
        public static void Test(int[] nums, out int max, out int min, out int sum, out int avg, out bool bo,out string s,out double d)
        {
            max = nums[0];
            min = nums[0];
            sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i]>max)
                {
                    max = nums[i];
                }
                if (nums[i]<min)
                {
                    min = nums[i];
                }
                sum += nums[i];
            }
            avg = sum / nums.Length;
            bo = true;
            s = "123";
            d = 1.23;
        }
    }
}
