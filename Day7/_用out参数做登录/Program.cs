using System;

namespace _用out参数做登录
{
    class Program
    {
        static void Main(string[] args)
        {
            //分别的提示用户输入用户名和密码
            //你写一个方法来判断用户输入的是否正确
            //返回给用户一个登陆结果，并且还要羊独的返回给用户一个登陆信息
            //如果用户名错误，除了退回登陆结果之外，还要返回一个“用户名错误"
            //“密码错误”
            Console.WriteLine("please write your name");
            string username = Console.ReadLine();
            Console.WriteLine("please write your password");
            string password = Console.ReadLine();
            string msg;
            bool b = IsLogIn(username,password,out msg);
            Console.WriteLine("sign in station {0}",b);
            Console.WriteLine("sign in message {0}",msg);
        }

        public static bool IsLogIn(string name,string pwd,out string msg)
        {
            if (name=="admin"&&pwd=="123")
            {
                msg = "登录成功";
                return true;
            }
            else if(name=="admin")
            {
                msg = "密码错误";
                return false;
            }
            else if (pwd=="123")
            {
                msg = "用户名错误";
                return false;
            }
            else
            {
                msg = "未知错误";
                return false; 
            }
           
        }
    }
}
