using System;

namespace 循环体
{
    class Program
    {
        static void Main(string[] args)
        {
            //要求用户输入用户名和密码用户名只要不是admin密码不是88888
            #region MyRegion1
            //string userName = "";
            //string userpwd = "";
            //Console.WriteLine("请输入用户名");
            //userName = Console.ReadLine();
            //while (userName != "admin")
            //{
            //    Console.WriteLine("请输入用户名");
            //    userName = Console.ReadLine();
            //}
            //while (userpwd != "88888")
            //{
            //    Console.WriteLine("请输入密码");
            //    userpwd = Console.ReadLine();
            //}
            //Console.WriteLine("success");
            #endregion


            //输入班级人数，然后一次输入学员成绩，计算班级学员平均成绩和总成绩
            #region MyRegion2
            //Console.WriteLine("请输入班级人数");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int i = 1;
            //int Nscore = 0;
            //while (i <= num)
            //{
            //    Console.WriteLine("请输入学员成绩");
            //    int score = Convert.ToInt32(Console.ReadLine());
            //    Nscore = Nscore + score;
            //    i++;
            //}
            //double avg = (double)Nscore / num;
            //Console.WriteLine("总成绩为{0}，平均成绩为{1}", Nscore, avg);
            #endregion


            //老师问学生,这道题你会做了吗?如果学生答"会了(y)",则可以放学.
            //如果学生不会做(n),则老师再讲一遍,再问学生是否会做了......
            //直到学生会为止,才可以放学.
            //直到学生会或老师给他讲了10遍还不会,都要放学
            #region MyRegion3
            string answer = "";
            int k = 1;
            while (answer != "yes" && k <= 10)
            {
                Console.WriteLine("这是我第{0}遍跟你讲，你这道题会了吗?yes/no", k);
                answer = Console.ReadLine();
                if (answer == "yes")
                {
                    Console.WriteLine("放学");
                    break;
                }
                k++;
            }
            #endregion

        }
    }
}
