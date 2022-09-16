

using System;

namespace _结构
{
    class Program
    {
        public struct MyColor
        {
            public int _red;
            public int _green;
            public int _blue;
        }

        public enum Gender
        {
            man,
            woman
        }

        public struct Person
        {
            public string _name;
            public int _age;
            public Gender _gender;
        }
        static void Main(string[] args)
        {
            //1 定义一个结构叫MyColor,有三个成员,分别定义为int类型的red,green,blue
            //声明一个 MyColor类型的变量,并对其成员赋值.使MyColor可以表示成一个红色
            MyColor mc;
            mc._red = 255;
            mc._green = 0;
            mc._blue = 0;

            //2 定义一个结构类型Person,有三个成员,分别为姓名,性别,年龄 性别用枚举类型
            //声明两个Person类型的变量,分别表示 张三 男  18岁/ 小兰 女 16岁
            Person zs;
            zs._gender = Gender.man;
            zs._name = "张三";
            zs._age = 18;

            Person xl;
            xl._name = "小兰";
            xl._gender = Gender.woman;
            xl._age = 16;

        }
    }
}
