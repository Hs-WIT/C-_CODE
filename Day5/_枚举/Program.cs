
using System;

namespace _枚举
{
    public enum QQState
    {
        OnLine = 1,
        OffLine,
        Leave,
        Busy,
        QMe
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please choose your qqstate: 1--online 2--offline 3--leave 4--busy 5--Qme");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    QQState s1 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("you choose qqstate is {0}", s1);
                    break;
                case "2":
                    QQState s2 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("you choose qqstate is {0}", s2);
                    break;
                case "3":
                    QQState s3 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("您选择的在线状态是{0}", s3);
                    break;
                case "4":
                    QQState s4 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("您选择的在线状态是{0}", s4);
                    break;
                case "5":
                    QQState s5 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("您选择的在线状态是{0}", s5);
                    break;
                default:
                    string err = "error";
                    Console.WriteLine("您选择的在线状态是{0}", err);
                    break;
            }
        }
    }
}
