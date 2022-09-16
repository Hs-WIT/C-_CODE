
using System;

namespace _判断闰年
{
    class program
    {
        static void Main(string[] args)
        {

            //输入年份，在输入月份，输出该月的天数（闰年判断方法） 
            Console.WriteLine("请输入年份");
            try
            {
                int year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请输入月份");
                try
                {
                    int month = Convert.ToInt32(Console.ReadLine());
                    int day = 0;
                    if (month >= 1 && month <= 12)
                    {
                        switch (month)
                        {
                            case 1:
                            case 3:
                            case 5:
                            case 7:
                            case 8:
                            case 10:
                            case 12:
                                day = 31;
                                break;
                            case 2:
                                if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                                {
                                    day = 29;
                                }
                                else
                                {
                                    day = 28;
                                }
                                break;
                            default:
                                day = 30;
                                break;
                        }
                        Console.WriteLine("{0}年{1}月有{2}天", year, month, day);
                    }
                    else
                    {
                        Console.WriteLine("month error");
                    }

                }//month 
                catch
                {
                    Console.WriteLine("month error");
                }
            }//year
            catch
            {
                Console.WriteLine("year error");
            }
        }
    }
}
