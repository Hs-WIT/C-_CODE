using System;

namespace _飞行棋
{
    class Program
    {
        //声明一个静态字段来模拟全局变量
        static int[] Maps = new int[100];
        //声明一个静态数组来存储玩家A跟玩家B的坐标
        static int[] PlayerPos = new int[2];
        //存储两个玩家的姓名
        static string[] PlayerNames = new string[2];
        //两个玩家的标记
        static bool[] Flags = new bool[2]; //默认是false
        static void Main(string[] args)
        {
            GameShow();
            GetPlayerName();
            //玩家姓名输入OK之后，我们首先应该清屏
            Console.Clear();    //清屏
            GameShow();
            Console.WriteLine("{0}的飞机用A表示", PlayerNames[0]);
            Console.WriteLine("{0}的飞机用B表示", PlayerNames[1]);
            InitalMaps();
            DrawMap();

            while (PlayerPos[0] < 99 && PlayerPos[1] < 99)
            {
                if (Flags[0] == false)
                {
                    PlayerGame(0);
                }
                else
                {
                    Flags[0] = false;
                }
                if (Flags[1] == false)
                {
                    PlayerGame(1);
                }
                if (PlayerPos[0] >= 99)
                {
                    Console.WriteLine("玩家{0}无耻的赢了玩家{1}", PlayerNames[0], PlayerNames[1]);
                    break;
                }
                if (PlayerPos[1] >= 99)
                {
                    Console.WriteLine("玩家{0}无耻的赢了玩家{1}", PlayerNames[1], PlayerNames[0]);
                    break;
                }
            }
            Win();
            Console.ReadKey();

        }

        /// <summary>
        /// 画游戏开始界面
        /// </summary>
        public static void GameShow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*********************************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*********************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("**********黄烁——飞行棋*********");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*********************************");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("*********************************");
        }

        /// <summary>
        /// 初始化地图
        /// </summary>
        public static void InitalMaps()
        {
            int[] LuckyTurn = { 6, 23, 40, 55, 69, 83 };//幸运轮盘◎
            int[] LandMine = { 5, 13, 17, 33, 38, 50, 64, 80, 94 };//地雷☆
            int[] Pause = { 9, 27, 60, 93 };//暂停▲
            int[] TimeTunnel = { 20, 25, 45, 63, 72, 88, 90 };//时空隧道卐
            for (int i = 0; i < LuckyTurn.Length; i++)
            {
                //int index = LuckyTurn[i];
                Maps[LuckyTurn[i]] = 1;
            }
            for (int i = 0; i < LandMine.Length; i++)
            {
                Maps[LandMine[i]] = 2;
            }
            for (int i = 0; i < Pause.Length; i++)
            {
                Maps[Pause[i]] = 3;
            }
            for (int i = 0; i < TimeTunnel.Length; i++)
            {
                Maps[TimeTunnel[i]] = 4;
            }
        }


        /// <summary>
        /// 画地图
        /// </summary>
        public static void DrawMap()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("图例:幸运轮盘:◎   地雷:☆   暂停:▲   时空隧道:卐");
            //第一横行
            for (int i = 0; i < 30; i++)
            {
                Console.Write(DrawStringMap(i));
            }
            Console.WriteLine();//画完第一行后换行

            //第一竖行
            for (int i = 30; i <= 34; i++)
            {

                for (int j = 0; j <= 28; j++)
                {
                    Console.Write("  ");
                }
                Console.WriteLine(DrawStringMap(i));
            }

            //第二横行
            for (int i = 64; i >= 35; i--)
            {
                Console.Write(DrawStringMap(i));
            }
            Console.WriteLine();//画完第二行后换行

            //第二竖行
            for (int i = 65; i <= 69; i++)
            {
                Console.WriteLine(DrawStringMap(i));
            }

            //第三横行
            for (int i = 70; i <= 99; i++)
            {
                Console.Write(DrawStringMap(i));
            }
            Console.WriteLine();//画完最后一行，换行
        }//DrawMap方法结尾


        /// <summary>
        /// 画地图的元素
        /// </summary>
        /// <param name="i">坐标</param>
        /// <returns>元素</returns>
        public static string DrawStringMap(int i)
        {
            #region 画图
            string str = "";
            //如果玩家A和玩家B的坐标相同，并且都在这个地图上，画一个“<>”
            if (PlayerPos[0] == PlayerPos[1] && PlayerPos[0] == i)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                str = "<>";
            }
            else if (PlayerPos[0] == i)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                str = "Ａ";
            }
            else if (PlayerPos[1] == i)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                str = "Ｂ";
            }
            else
            {
                switch (Maps[i])
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.White;
                        str = "□";
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        str = "◎";
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        str = "☆";
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        str = "▲";
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        str = "卐";
                        break;
                }
            }
            return str;
            #endregion
        }
        /// <summary>
        ///获取玩家姓名
        /// </summary>
        public static void GetPlayerName()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("请输入玩家A的姓名");
            PlayerNames[0] = Console.ReadLine();
            while (PlayerNames[0] == "")
            {
                Console.WriteLine("玩家A姓名不能为空,请重新输入");
                PlayerNames[0] = Console.ReadLine();
            }
            Console.WriteLine("请输入玩家B的姓名");
            PlayerNames[1] = Console.ReadLine();
            while (PlayerNames[1] == "" || PlayerNames[0] == PlayerNames[1])
            {
                if (PlayerNames[1] == "")
                {
                    Console.WriteLine("玩家B姓名不能为空,请重新输入");
                    PlayerNames[1] = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("玩家B姓名不能与玩家A的姓名一样,请重新输入");
                }
                PlayerNames[1] = Console.ReadLine();
            }
        }

        /// <summary>
        /// 玩游戏流程
        /// </summary>
        public static void PlayerGame(int playernumber)
        {
            Random r = new Random();
            int rNumber = r.Next(1, 7);
            Console.WriteLine("{0}按下任意键开始掷骰子", PlayerNames[playernumber]);
            Console.ReadKey(true);//不显示按下的键
            Console.WriteLine("{0}掷出来了{1}", PlayerNames[playernumber], rNumber);
            PlayerPos[playernumber] += rNumber;
            ChangePos();
            Console.ReadKey(true);
            Console.WriteLine("{0}按任意键开始行动", PlayerNames[playernumber]);
            Console.ReadKey(true);
            Console.WriteLine("{0}行动完了", PlayerNames[playernumber]);
            Console.ReadKey(true);
            //玩家A有可能踩到 玩家B  方块  幸运轮盘 地雷 暂停 时空隧道
            if (PlayerPos[playernumber] == PlayerPos[1 - playernumber])   //踩到了玩家
            {
                Console.WriteLine("玩家{0}踩到了玩家{1}，玩家{2}退6格", PlayerNames[playernumber], PlayerNames[1 - playernumber], PlayerNames[1 - playernumber]);
                PlayerPos[1 - playernumber] -= 6;
                ChangePos();
                Console.ReadKey(true);
            }
            else //踩到了关卡
            {
                switch (Maps[PlayerPos[playernumber]])
                {
                    case 0:
                        Console.WriteLine("玩家{0}踩到了方块，安全", PlayerNames[playernumber]);
                        break;
                    case 1:
                        Console.WriteLine("玩家{0}踩到了幸运轮盘，请选择 1--交换位置 2--轰炸对方", PlayerNames[playernumber]);
                        string input = Console.ReadLine();
                        while (true)
                        {
                            if (input == "1")
                            {
                                Console.WriteLine("玩家{0}选择跟玩家{1}交换位置", PlayerNames[playernumber], PlayerNames[1 - playernumber]);
                                Console.ReadKey(true);
                                int temp = PlayerPos[playernumber];
                                PlayerPos[playernumber] = PlayerPos[1 - playernumber];
                                PlayerPos[1 - playernumber] = temp;
                                Console.WriteLine("交换完成，请按任意键继续游戏");
                                Console.ReadKey(true);
                                break;
                            }
                            else if (input == "2")
                            {
                                Console.WriteLine("玩家{0}选择轰炸对方", PlayerNames[playernumber]);
                                Console.ReadKey(true);
                                PlayerPos[1 - playernumber] -= 6;
                                ChangePos();
                                Console.WriteLine("玩家{0}遭到玩家{1}轰炸，退6格", PlayerNames[playernumber], PlayerNames[1 - playernumber]);
                                Console.ReadKey(true);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("无效选择，请重新选择1--交换位置 2--轰炸对方");
                                input = Console.ReadLine();
                            }
                        }

                        break;
                    case 2:
                        Console.WriteLine("玩家{0}踩到了地雷，退6格", PlayerNames[playernumber]);
                        Console.ReadKey(true);
                        PlayerPos[playernumber] -= 6;
                        ChangePos();
                        break;
                    case 3:
                        Console.WriteLine("玩家{0}踩到了暂停,暂停-回合", PlayerNames[playernumber]);
                        Flags[playernumber] = true;
                        Console.ReadKey(true);
                        break;
                    case 4:
                        Console.WriteLine("玩家{0}踩到了时空隧道,前进10格", PlayerNames[playernumber]);
                        PlayerPos[playernumber] += 10;
                        ChangePos();
                        Console.ReadKey(true);
                        break;
                    default:
                        break;
                }
            }
            ChangePos();    //清屏之前调用
            Console.Clear();
            DrawMap();
        }

        /// <summary>
        /// 当玩家坐标发生改变的时候调用
        /// </summary>
        public static void ChangePos()
        {
            if (PlayerPos[0] < 0)
            {
                PlayerPos[0] = 0;
            }
            if (PlayerPos[0] >= 99)
            {
                PlayerPos[0] = 99;
            }
            if (PlayerPos[1] < 0)
            {
                PlayerPos[1] = 0;
            }
            if (PlayerPos[1] >= 99)
            {
                PlayerPos[1] = 99;
            }

        }


        public static void Win()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　
　　　　　　　　　　■■■　　　　　　　　　■■　　　　　　　　　
　■■■■■　■■　■■　　　　　■■■■■■■　　　　■■　　
　■■■■■　■■　■■　　　　　■■■■■　　　　　　■■　　
　■■　■■　■■■■■■■■　　　　　■■　　　■■　■■　　
　■■　■■　■■■■■■■■　　　　　■■　　　■■　■■　　
　■■■■■■■　　■■　　　　■■■■■■■■　■■　■■　　
　■■　■■　　　　■■　　　　■■■■■■■■　■■　■■　　
　■■　■■　　■■■■■■　　　　　■■■　　　■■　■■　　
　■■■■■　　■■■■■■　　　　■■■■■　　■■　■■　　
　■■　■■　　　　■■　　　　　■■　■■■■　■■　■■　　
　■■　■■　　　　■■　　　　■■■　■■　■　■■　■■　　
　■■　■■　　　　■■　　　　　■　　■■　　　　　　■■　　
　■■　■■　■■■■■■■■　　　　　■■　　　　　　■■　　
■■　■■■　■■■■■■■■　　　　　■■　　　　　■■■　　
■■　■■　　　　　　　　　　　　　　　■■　　　　　■■　　　");
        }
    }
}
