namespace Game8_10
{
    #region 背景列表
    enum E_NowScene
    {
        /// <summary>
        /// 开始界面
        /// </summary>
        Begin,
        /// <summary>
        /// 游戏界面
        /// </summary>
        Game,
        /// <summary>
        /// 结束界面
        /// </summary>
        End,
    }
    #endregion

    #region 格子列表
    enum E_Gird
    {
        /// <summary>
        /// 普通格子
        /// </summary>
        Common,
        /// <summary>
        /// 暂停格子
        /// </summary>
        Pause,
        /// <summary>
        /// 炸弹格子
        /// </summary>
        Tnt,
        /// <summary>
        /// 时空隧道
        /// </summary>
        Wormhole,
    }
    #endregion
    internal class Program
    {
        #region 控制台初始化
        static void ConsoleInit(int width, int height)
        {
            //光标隐藏
            Console.CursorVisible = false;
            Console.SetWindowSize(width, height);
            Console.SetBufferSize(width, height);
        }
        #endregion

        #region 开始界面逻辑
        static void BeginScene(int width, int heigth, ref E_NowScene nowScene)
        {
            Console.SetCursorPosition(width / 2 - 4, 8);
            Console.WriteLine("飞 行 棋");
            //表示当前选中的选项
            int nowSelect = 0;
            //定义一个变量用来退出循环
            bool isExit = false;
            while (true)
            {
                //如果选中当前选项，则文字变红，否则是白色，默认选择开始游戏
                Console.SetCursorPosition(width / 2 - 4, 15);
                Console.ForegroundColor = nowSelect == 0 ? ConsoleColor.Red : ConsoleColor.White;
                Console.WriteLine("开始游戏");

                Console.SetCursorPosition(width / 2 - 4, 20);
                Console.ForegroundColor = nowSelect == 1 ? ConsoleColor.Red : ConsoleColor.White;
                Console.WriteLine("退出游戏");

                //通过ReadKey可以得到一个输入的枚举类型
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.W:
                        if (nowSelect == 0)
                            nowSelect = 1;
                        nowSelect = 0;
                        break;
                    case ConsoleKey.S:
                        if (nowSelect == 1)
                            nowSelect = 0;
                        nowSelect = 1;
                        break;
                    case ConsoleKey.J:
                        if (nowSelect == 0)
                        {
                            nowScene = E_NowScene.Game;
                            isExit = true;
                        }
                        else
                        {
                            Environment.Exit(0);
                        }
                        break;
                }
                if (isExit)
                    break;
            }
        }
        #endregion

        #region 格子
        /// <summary>
        /// 位置信息结构体
        /// </summary>
        struct Vector2
        {
            public int x;
            public int y;
            public Vector2(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        struct Gird
        {
            public E_Gird type;
            public Vector2 position;

            public Gird(int x, int y, E_Gird type)
            {
                position.x = x;
                position.y = y;
                this.type = type;
            }

            public void DrawGird()
            {
                Console.SetCursorPosition(position.x, position.y);
                switch (type)
                {
                    case E_Gird.Common:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("□");
                        break;
                    case E_Gird.Pause:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("⊙");
                        break;
                    case E_Gird.Tnt:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("●");
                        break;
                    case E_Gird.Wormhole:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("※");
                        break;
                }
            }
        }
        #endregion

        #region 地图
        struct Map
        {
            public Gird[] girds;
            public Map(int x, int y, int num)
            {
                girds = new Gird[num];
                //记录当前格子x轴和y轴移动了多少步
                int indexX = 0, indexY = 0;
                //记录x和y的步长
                int Xstep = 2;

                //计算每种格子生成的概率
                Random rand = new Random();
                int randNum = 0;

                for (int i = 0; i < num; i++)
                {
                    randNum = rand.Next(0, 101);
                    //85%的几率是普通格子，并且起点和终点不能是特殊格子
                    if (randNum < 85 || i == 0 || i == num - 1)
                    {
                        girds[i].type = E_Gird.Common;
                    }
                    //5%的几率是暂停格子
                    else if (randNum >= 85 && randNum < 90)
                    {
                        girds[i].type = E_Gird.Pause;
                    }
                    //5%的几率是炸弹格子
                    else if (randNum >= 90 && randNum < 95)
                    {
                        girds[i].type = E_Gird.Tnt;
                    }
                    //5%的几率是时空隧道
                    else
                    {
                        girds[i].type = E_Gird.Wormhole;
                    }

                    girds[i].position = new Vector2(x, y);

                    if (indexX == 10)
                    {
                        y += 1;
                        indexY++;
                        if (indexY == 2)
                        {
                            indexX = 0;
                            indexY = 0;
                            Xstep = -Xstep;
                        }
                    }
                    else
                    {
                        x += Xstep;
                        indexX++;
                    }
                }
            }
            public void DrawMap()
            {
                for (int i = 0; i < girds.Length; i++)
                {
                    girds[i].DrawGird();
                }
            }
        }
        #endregion

        #region 游戏场景逻辑
        static void GameScene(int width, int height)
        {
            //绘制红墙和提示文本
            RedWall(width, height);

            //绘制地图格子
            Map map = new Map(20, 2, 83);
            map.DrawMap();
            while (true)
            {

            }
        }
        #endregion

        #region 红墙和提示文本
        static void RedWall(int width, int height)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < width; i += 2)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("■");

                Console.SetCursorPosition(i, height - 13);
                Console.Write("■");

                Console.SetCursorPosition(i, height - 7);
                Console.Write("■");

                Console.SetCursorPosition(i, height - 1);
                Console.Write("■");
            }
            for (int i = 0; i < height; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("■");

                Console.SetCursorPosition(width - 2, i);
                Console.Write("■");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(2, height - 12);
            Console.Write("□：普通格子");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(2, height - 11);
            Console.Write("⊙：暂停，一回合不能动");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(26, height - 11);
            Console.Write("●：炸弹，倒退五格");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(2, height - 10);
            Console.Write("※：时空隧道，随机暂停、倒退、换位置");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(2, height - 9);
            Console.Write("★：玩家");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(12, height - 9);
            Console.Write("▲：电脑");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(2, height - 8);
            Console.Write("◎：玩家和电脑重合");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(2, height - 6);
            Console.Write("按任意键开始游戏");
        }
        #endregion

        static void Main(string[] args)
        {
            //设置窗口大小
            int width = 60;
            int height = 30;
            ConsoleInit(width, height);
            
            E_NowScene nowScene = E_NowScene.Begin;

            //定义谁移动的变量
            bool isPlayer = true;
            
            while (true)
            {
                switch (nowScene)
                {
                    #region 开始界面
                    case E_NowScene.Begin:
                        //刷新界面
                        Console.Clear();

                        //开始界面逻辑
                        BeginScene(width, height, ref nowScene);

                        break;
                    #endregion

                    #region 游戏界面
                    case E_NowScene.Game:

                        Console.Clear();
                        //游戏场景函数调用
                        GameScene(width, height);
                        break;
                    #endregion

                    #region 结束界面
                    case E_NowScene.End:
                        break;
                        #endregion

                }
            }
            
        }
    }
}
