using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //练习，编程实现计算几天（如46天）是几周零几天
            int days = 46;
            int weeks = days / 7;
            int day = 46 % 7;
            Console.WriteLine("{0}天是{1}周零{2}天", days, weeks, day);

            //编程实现107653秒是几天几小时几分钟几秒
            int times = 107653;
            int Day = times / (24 * 60 * 60);       //求得天数
            int second = times % (24 * 60 * 60);    //秒数
            int hour = second / 3600;
            second = second % 3600;
            int minute = second / 60;
            second = second % 60;
            Console.WriteLine("{0}秒是{1}天{2}小时{3}分钟{4}秒", times, Day, hour, minute, second);


            //让用户输入姓名 语文、数学、英语三门课成绩
            //然后给用户显示：**，你的总成绩为xx分。平均成绩为xx分
            Console.WriteLine("请输入你的姓名");
            string  name=Console.ReadLine();
            Console.WriteLine("请输入你的语文成绩");
            string strChinese = Console.ReadLine();
            Console.WriteLine("请输入你的数学成绩");
            string strMath = Console.ReadLine();
            Console.WriteLine("请输入你的英语成绩");
            string strEnglish = Console.ReadLine();

            int chinese=Convert.ToInt32(strChinese);
            int math = Convert.ToInt32(strMath);
            int english = Convert.ToInt32(strEnglish);
            Console.WriteLine("{0}您的总成绩是{1}，平均成绩是{2}", name,chinese+math+english,(chinese + math + english)/3);
        }
    }
}
