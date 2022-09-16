

using System;

namespace _方法练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //79、用方法来实现:有一一个字符串数组:
            //{ "马龙"，"迈克尔乔丹"，“雷吉米勒"，“蒂姆邓肯"，“科比布莱恩特”} ,请输出最长的字符串
            string[] names = { "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特", "12345579876" };
            string max = GetLongestStr(names);
            Console.WriteLine(max);
            Console.ReadKey();

            //计算一个整形数组的平均值
            int[] nums = { 1, 2, 3, 5 };
            double avg = GetAvg(nums);
            Console.WriteLine("{0:0.00}", avg);

            //判断质数
            //while (true)
            //{
            Console.WriteLine("Please scanf the number");
            string strnumber = Console.ReadLine();
            int number = Getnumber(strnumber);
            bool b = IsPrime(number);
            Console.WriteLine(b);
            //}

            //95、接受输入后判断其等级并显示出来。
            //判断依据如下:等级={优( 90~100分) ;良( 80~89分)
            Console.WriteLine("please scanf your test score");
            int score = Convert.ToInt32(Console.ReadLine());
            string level=GetLevel(score);
            Console.WriteLine(level);

            //97、请将字符串数组{“中国"，"美国"，“巴西"，"澳大利亚"，“加拿大”}中的内容反转
            string[] countryname = { "中国", "美国", "澳大利亚","巴西","加拿大" };
            for (int i = 0; i < countryname.Length/2; i++)
            {
                string tmp = countryname[i];
                countryname[i] = countryname[countryname.Length-i-1];
                countryname[countryname.Length - 1 - i] = tmp;
            }
            for (int i = 0; i < countryname.Length; i++)
            {
                Console.WriteLine(countryname[i]);
            }

            Test(countryname);
            for (int i = 0; i < countryname.Length; i++)
            {
                Console.WriteLine(countryname[i]);
            }

            //求圆的面积和周长
            double r = 5;
            double peimeter;
            double area;
            GetPerimeterArea(r,out peimeter,out area);
            Console.WriteLine(peimeter);
            Console.WriteLine(area);

            //求数组之和
            int sum = GetSum(1,2,3,4,5,78);
            Console.WriteLine(sum);

            //102将一个字符串数组输出为|分割的形式,比如“梅西|卡卡|郑大世”(用方法来实现此功能)
            string[] pname = { "梅西","卡卡","正大"};
            string str = ProcessString(pname);
            Console.WriteLine(str);
        }

        public static string ProcessString(string[] pname)
        {
            string str = null;
            for (int i = 0; i < pname.Length-1; i++)
            {
                str += pname[i] + "|";
            }
            return str+pname[pname.Length-1];
        }

        
        /// <summary>
        /// 数组求和
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int GetSum(params int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }


        /// <summary>
        /// 求圆的面积、周长
        /// </summary>
        /// <param name="r"></param>
        /// <param name="perimeter"></param>
        /// <param name="area"></param>
        public static void GetPerimeterArea(double r, out double perimeter, out double area)
        {
            perimeter = 2 * 3.14 * r;
            area = 3.14 * r * r;
        }



        /// <summary>
        /// 将字符数组内容反转
        /// </summary>
        /// <param name="countryname"></param>
        public static void Test(string[] countryname)
        {
            for (int i = 0; i < countryname.Length / 2; i++)
            {
                string tmp = countryname[i];
                countryname[i] = countryname[countryname.Length - i - 1];
                countryname[countryname.Length - 1 - i] = tmp;
            }
        }


        /// <summary>
        /// 判断其等级
        /// </summary>
        /// <param name="score"></param>
        /// <returns></returns>
        public static string  GetLevel(int score)
        {
            string level = "";
            switch (score / 10)
            {
                case 10:
                case 9: level = "优秀";
                    break;
                case 8: level = "良好";
                    break;
                case 7:level = "中等";
                    break;
                case 6:level = "差";
                    break;
                default:level = "不及格";
                    break;

            }
            return level;
        }
        /// <summary>
        /// 输出字符串数组中最长的字符串
        /// </summary>
        /// <param name="s">字符串数组</param>
        /// <returns>最长的字符串</returns>
        public static string GetLongestStr(string[] s)
        {
            string max = s[0];
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Length > max.Length)
                {
                    max = s[i];
                }
            }
            return max;
        }
        /// <summary>
        ///计算一个整形数组的平均值
        /// </summary>
        /// <param name="nums">整形数组</param>
        /// <returns>整形数组元素的平均值</returns>
        public static double GetAvg(int[] nums)
        {
            double sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum / nums.Length;
        }

        /// <summary>
        /// 要求用户只能输入数字输入有误就一直让用户输入
        /// </summary>
        /// <param name="strnumber"></param>
        /// <returns></returns>
        public static int Getnumber(string strnumber)
        {
            while (true)
            {
                try
                {
                    int number = Convert.ToInt32(strnumber);
                    return number;
                }
                
                catch (Exception)
                {
                    Console.WriteLine("please enter again");
                    strnumber = Console.ReadLine();
                }
            }
        }

        /// <summary>
        /// 用来判断数字是不是质数
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }
            else
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

    }
}
