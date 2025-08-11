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

    #region 玩家列表
    enum E_PlayerType
    {
        Player,
        AI,
    }
    #endregion

    #region 玩家结构体
    struct Player
    {
        //玩家类型
        public E_PlayerType type;
        //当前玩家格子的下标
        public int nowIndex;
        //判断玩家是否踩到暂停格子
        public bool isPause;

        public Player(int index, E_PlayerType type)
        {
            nowIndex = index;
            this.type = type;
            this.isPause = false;
        }

        public void Draw(Map map)
        {
            //必须先得到地图才能得到地图上格子的信息
            //得到所有格子的信息
            Gird gird = map.girds[nowIndex];
            //设置位置
            Console.SetCursorPosition(gird.position.x, gird.position.y);
            switch (type)
            {
                case E_PlayerType.Player:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("★");
                    break;
                case E_PlayerType.AI:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("▲");
                    break;
            }
        }
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

        #region 游戏场景逻辑
        static void GameScene(int width, int height, ref E_NowScene nowScene)
        {
            //绘制红墙和提示文本
            RedWall(width, height);

            //绘制地图格子
            Map map = new Map(20, 2, 83);
            map.DrawMap();
            //打印玩家和电脑
            Player player = new Player(0, E_PlayerType.Player);
            Player AI = new Player(0, E_PlayerType.AI);
            DrawPlayer(player, AI, map);

            //添加一个游戏结束标识
            bool isGameOver = false;
            while (true)
            {
                //玩家扔色子逻辑
                //检测输入
                Console.ReadKey(true);
                //扔色子的逻辑
                isGameOver = ThrowDice(width, height, ref player, ref AI, map);
                //绘制地图
                map.DrawMap();
                //绘制玩家
                DrawPlayer(player, AI, map);
                //判断是否要结束游戏
                if (isGameOver)
                {
                    //卡住程序 让顽疾按任意键 
                    Console.ReadKey(true);
                    //改变场景ID
                    nowScene = E_NowScene.End;
                    //直接跳出循环
                    break;
                }

                //电脑扔色子逻辑
                //检测输入
                Console.ReadKey(true);
                //扔色子的逻辑
                isGameOver = ThrowDice(width, height, ref AI, ref player, map);
                //绘制地图
                map.DrawMap();
                //绘制玩家
                DrawPlayer(player, AI, map);
                //判断是否要结束游戏
                if (isGameOver)
                {
                    //卡住程序 让顽疾按任意键 
                    Console.ReadKey(true);
                    //改变场景ID
                    nowScene = E_NowScene.End;
                    //直接跳出循环
                    break;
                }
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

        #region 绘制玩家
        static void DrawPlayer(Player player, Player AI, Map map)
        {
            //重合时
            if (player.nowIndex == AI.nowIndex)
            {
                //得到重合时的位置
                Gird gird = map.girds[player.nowIndex];
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(gird.position.x, gird.position.y);
                Console.Write("◎");
            }
            //不重合时
            else
            {
                player.Draw(map);
                AI.Draw(map);
            }
        }
        #endregion

        #region 擦除信息
        static void Erase(int h)
        {
            Console.SetCursorPosition(0, h - 6);
            Console.Write("                                             ");
            Console.SetCursorPosition(0, h - 5);
            Console.Write("                                             ");
            Console.SetCursorPosition(0, h - 4);
            Console.Write("                                             ");
            Console.SetCursorPosition(0, h - 3);
            Console.Write("                                             ");
        }
        #endregion

        #region 扔骰子
        /// <summary>
        /// 随机扔骰子改变传入玩家的位置
        /// </summary>
        /// <param name="width">窗口的宽</param>
        /// <param name="height">窗口的高</param>
        /// <param name="player">玩家</param>
        /// <param name="AI">电脑</param>
        /// <param name="map">地图</param>
        /// <returns>默认不结束游戏</returns>
        static bool ThrowDice(int width, int height, ref Player player, ref Player AI, Map map)
        {
            //擦除之前打印的信息
            Erase(height);

            //判断是否处于暂停状态
            if (player.isPause)
            {
                Console.SetCursorPosition(2, height - 6);
                Console.Write("{0}踩到了暂停格子，还需要休息一回合", player.type == E_PlayerType.Player ? "你" : "电脑");
                Console.SetCursorPosition(2, height - 5);
                Console.Write("请按任意键，开始{0}的回合", player.type == E_PlayerType.Player ? "你" : "电脑");
                player.isPause = false;
                return false;
            }
            //创建骰子点数
            Random rand = new Random();
            int point = rand.Next(1, 7);
            //把骰子点数加上去，改变位置
            player.nowIndex += point;
            //打印扔的点数
            Console.SetCursorPosition(2, height - 6);
            Console.Write("{0}扔出了{1}点，向前移动{2}格", player.type == E_PlayerType.Player ? "你" : "电脑", point, point);

            //判断是否到达终点
            if (player.nowIndex >= map.girds.Length - 1)
            {
                player.nowIndex = map.girds.Length - 1;
                Console.SetCursorPosition(2, height - 5);
                if (player.type == E_PlayerType.Player)
                {
                    Console.Write("恭喜你，你率先到达了终点");
                }
                else
                {
                    Console.Write("很遗憾，电脑率先到达了终点");
                }
                return true;
            }
            //没有到达终点
            else
            {
                Gird gird = map.girds[player.nowIndex];

                switch (gird.type)
                {
                    case E_Gird.Common:
                        Console.SetCursorPosition(2, height - 5);
                        Console.Write("{0}到达了一个安全位置，无事发生", player.type == E_PlayerType.Player ? "你" : "电脑"); 
                        Console.SetCursorPosition(2, height - 4);
                        Console.Write("请按任意键，开始{0}的回合", player.type == E_PlayerType.Player ? "电脑" : "你");
                        break;
                    case E_Gird.Pause:
                        player.isPause = true;
                        Console.SetCursorPosition(2, height - 5);
                        Console.Write("{0}触发了暂停陷阱，下回合不能行动", player.type == E_PlayerType.Player ? "你" : "电脑");
                        Console.SetCursorPosition(2, height - 4);
                        Console.Write("请按任意键，开始{0}的回合", player.type == E_PlayerType.Player ? "电脑" : "你");
                        break;
                    case E_Gird.Tnt:
                        player.nowIndex -= 5;
                        if (player.nowIndex < 0)
                        {
                            player.nowIndex = 0;
                        }
                        Console.SetCursorPosition(2, height - 5);
                        Console.Write("{0}触发了炸弹陷阱，位置倒退5格", player.type == E_PlayerType.Player ? "你" : "电脑");
                        Console.SetCursorPosition(2, height - 4);
                        Console.Write("请按任意键，开始{0}的回合", player.type == E_PlayerType.Player ? "电脑" : "你");
                        break;
                    case E_Gird.Wormhole:
                        Console.SetCursorPosition(2, height - 5);
                        Console.Write("{0}触发了时空隧道", player.type == E_PlayerType.Player ? "你" : "电脑");

                        //随机触发
                        point = rand.Next(1, 91);
                        //触发暂停
                        if (point <= 30)
                        {
                            player.isPause = true;
                            Console.SetCursorPosition(2, height - 4);
                            Console.Write("触发了暂停");
                        }
                        //触发倒退
                        else if (point <= 60)
                        {
                            player.nowIndex -= 5;
                            if (player.nowIndex < 0)
                            {
                                player.nowIndex = 0;
                            }
                            Console.SetCursorPosition(2, height - 4);
                            Console.Write("触发了倒退5格");
                        }
                        //交换位置
                        else
                        {
                            int temp = player.nowIndex;
                            player.nowIndex = AI.nowIndex;
                            AI.nowIndex = temp;
                            Console.SetCursorPosition(2, height - 3);
                            Console.Write("双方交换位置");
                        }

                        Console.SetCursorPosition(2, height - 2);
                        Console.Write("请按任意键，让{0}开始扔色子", player.type == E_PlayerType.Player ? "电脑" : "你");
                        break;
                }
            }
            return false;
        }
        #endregion


        static void Main(string[] args)
        {
            //设置窗口大小
            int width = 60;
            int height = 30;
            ConsoleInit(width, height);
            
            E_NowScene nowScene = E_NowScene.Begin;
            
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
                        GameScene(width, height, ref nowScene);
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
