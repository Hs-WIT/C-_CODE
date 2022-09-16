using System;

namespace 练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //不断要求用户输入一个数字（假定用户输入的都是正整数），当用户输入end的时候显示刚才输入的数字中的最大值
            string input = "";
            int max = 0;
            while (input != "end")
            {
                Console.WriteLine("please input a number,scanf \"end\" the window will display the max number you scanf");
                input = Console.ReadLine();
                if (input != "end")
                {
                    try
                    {
                        int number = Convert.ToInt32(input);
                        if (number > max)
                        {
                            max = number;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("you scanf string can't convert number,please try again");
                    }

                }
                else
                {
                    Console.WriteLine("you scanf the max number is {0}", max);
                }
            }



        }
    }
}
