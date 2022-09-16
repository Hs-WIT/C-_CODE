using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int salary = 5000;
           bool b = true;
            Console.WriteLine("输入评级");
            string level = Console.ReadLine();

            switch(level)
            {
                case "A":salary += 500;
                    break;
                case "B":salary += 200;
                    break;
                case "C":salary -= 200;
                    break;
                default:Console.WriteLine("error");
                    b = false;
                    break;

            }
            if (b) 
            {
                Console.WriteLine("salary is {0}", salary);
            }
           

        }
    }
}
