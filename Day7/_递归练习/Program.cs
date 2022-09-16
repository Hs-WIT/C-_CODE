using System;

namespace _递归练习
{
    class Program
    {
        static void Main(string[] args)
        {
            // 提示用户输入两个数字  计算这两个数字之间所有整数的和
            //1、用户只能输入数字
            //2、计算两个数字之间和
            //3、要求第一个数字必须比第二个数字小  否则就重新输入
            Console.WriteLine("please input the first number");
            string strnumberone = Console.ReadLine();
            Console.WriteLine("please input the second number");
            string strnumbertwo = Console.ReadLine();
            int intnumberone;
            int intnumbertwo;
            GetNumber(strnumberone,out intnumberone);
            GetNumber(strnumbertwo,out intnumbertwo);
            JudgeNumber(ref intnumberone,ref intnumbertwo);

            int sum = GetSum(intnumberone,intnumbertwo);
            Console.WriteLine(sum); 
        }
        public static void JudgeNumber(ref int n1, ref int n2)
        {
            while (true)
            {
                if (n1 < n2)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("the first number can greater than the second number,please reinput the first number");
                    string s1 = Console.ReadLine();
                    GetNumber(s1, out n1);
                    Console.WriteLine("please reinput the second nubmer");
                    string s2 = Console.ReadLine();
                    GetNumber(s2, out n2);
                }
            }
        }
        public static void GetNumber(string s, out int number)
        {
            while (true)
            {
                try
                {
                    number = Convert.ToInt32(s);
                    return;
                }
                catch (Exception)
                {
                    Console.WriteLine("input error! please reinput");
                }
            }
        }
        public static int GetSum(int n1, int n2)
        {
            int sum = 0;
            for (int i = n1; i <= n2; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
