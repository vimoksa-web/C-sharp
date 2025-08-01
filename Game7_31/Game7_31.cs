namespace Game7_31_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //隐藏光标
            Console.CursorVisible = false;

            //设置窗口大小
            int w = 60;
            int h = 30;
            Console.SetWindowSize(w, h);
            Console.SetBufferSize(w, h);

            //定义场景参数
            int backGround = 1;

            //不同结局显示的文字
            int gameoverInfo = 0;

            //场景切换
            while (true)
            {
                switch (backGround)
                {
                    case 1:

                        #region 开始场景
                        //显示场景1信息
                        Console.Clear();
                        //让文字居中
                        Console.SetCursorPosition(w / 2 - 7, 8);
                        Console.Write("勇 者 斗 恶 龙");

                        //新建一个变量表示当前选中的选项
                        int nowSelect = 0;

                        //新建一个循环专门用来处理场景1的逻辑
                        while (true)
                        {

                            Console.SetCursorPosition(w / 2 - 4, 15);
                            //如果选项在0，则文字颜色为红色，反之则为白色
                            Console.ForegroundColor = nowSelect == 0 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.Write("开始游戏");

                            Console.SetCursorPosition(w / 2 - 4, 20);
                            Console.ForegroundColor = nowSelect == 1 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.Write("退出游戏");

                            //如果要从while循环中的switch语句中直接退出while循环，需要在while层新建一个变量专门用来退出循环
                            //switch循环中的break是不能直接退出while循环的
                            bool isExit = false;

                            char input = Console.ReadKey(true).KeyChar;

                            switch (input)
                            {
                                case 'W':
                                case 'w':
                                    nowSelect = 0;
                                    break;
                                case 'S':
                                case 's':
                                    nowSelect = 1;
                                    break;
                                //用户按J确认，确认后需要更换场景或者退出程序
                                case 'J':
                                case 'j':
                                    if ( nowSelect == 0)
                                    {
                                        backGround = 2;
                                        //令变量为真，使判断条件成立
                                        isExit = true;
                                    }
                                    else
                                    {
                                        Environment.Exit(0); 
                                    }
                                    break;
                            }
                            if (isExit)
                            {
                                break;
                            }
                        }
                        #endregion
                        break;

                    case 2:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;

                        #region 背景红墙
                        for (int i = 0; i < w; i += 2)
                        {
                            //上方的墙
                            Console.SetCursorPosition(i, 0);
                            Console.Write("█");
                            //中间的墙
                            Console.SetCursorPosition(i, h - 8);
                            Console.Write("█");
                            //下方的墙
                            Console.SetCursorPosition(i, h - 1);
                            Console.Write("█");
                        }

                        for (int i = 0; i < h; i++)
                        {
                            //左边的墙
                            Console.SetCursorPosition(0, i);
                            Console.Write("█");
                            //右边的墙
                            Console.SetCursorPosition(w - 2, i);
                            Console.Write("█");
                        }
                        #endregion

                        #region Boss属性
                        //Boss的位置
                        int BossX = w / 2;
                        int BossY = (h - 8) / 2 + 2;
                        //Boss的数值
                        Random a = new Random();
                        int BossAtkMin = 10;
                        int BossAtkMax = 15;
                        int BossHp = 100;
                        string BossTB = "⊙";
                        //可以声明颜色变量
                        ConsoleColor BossColor = ConsoleColor.Magenta;
                        #endregion

                        #region 主角属性
                        //定义主角坐标
                        int LeadX = 2;
                        int LeadY = 1;
                        Random l = new Random();
                        int LeadAtkMin = 8;
                        int LeadAtkMax = 17;
                        int LeadHp = 100;
                        string LeadTB = "★";
                        ConsoleColor LeadColor = ConsoleColor.Yellow;
                        //玩家输入的内容，从外面声明节约性能
                        char leadInput;
                        #endregion

                        #region 公主属性
                        int princessX = w / 2;
                        int princessY = 5;
                        string princessTB = "●";
                        ConsoleColor princessColor = ConsoleColor.Blue;
                        #endregion

                        //定义战斗状态
                        bool isFight = false;
                        //定义游戏是否可以结束
                        bool isEnd = false;

                        while (true)
                        {
                            #region Boss信息
                            if (BossHp > 0)
                            {
                                Console.ForegroundColor = BossColor;
                                Console.SetCursorPosition(BossX, BossY);
                                Console.Write(BossTB);
                            }
                            #region 公主相关
                            else
                            {
                                Console.ForegroundColor = princessColor;
                                Console.SetCursorPosition(princessX, princessY);
                                Console.Write(princessTB);
                            }
                            #endregion

                            #endregion

                            //打印主角的位置
                            Console.SetCursorPosition(LeadX, LeadY);
                            Console.ForegroundColor = LeadColor;
                            Console.Write(LeadTB);

                            leadInput = Console.ReadKey(true).KeyChar;

                            //战斗状态要做什么事
                            if (isFight)
                            {
                                if (leadInput == 'J' || leadInput == 'j')
                                {
                                    //结束战斗后要做的事
                                    if (BossHp <= 0)
                                    {
                                        //Boss死亡后做的事
                                        Console.SetCursorPosition(BossX, BossY);
                                        Console.Write("  ");
                                        isFight = false;
                                    }
                                    else if (LeadHp <= 0)
                                    {
                                        //主角死亡后做的事
                                        backGround = 3;
                                        //坏结局
                                        gameoverInfo = 0;
                                        break;
                                    }
                                    else
                                    {
                                        //主角打恶龙
                                        Random r = new Random();
                                        int LeadAtk = r.Next(LeadAtkMin, LeadAtkMax);
                                        BossHp -= LeadAtk;

                                        //擦除上次显示的战斗信息
                                        Console.ForegroundColor = BossColor;
                                        Console.SetCursorPosition(2, h - 6);
                                        Console.Write("                                             ");
                                        //显示这一次的战斗信息
                                        Console.SetCursorPosition(2, h - 6);
                                        Console.Write("你对Boss造成了{0}伤害，Boss剩余血量为{1}", LeadAtk, BossHp);

                                        //恶龙打主角
                                        if (BossHp > 0)
                                        {
                                            int BossAtk = r.Next(BossAtkMin, BossAtkMax);
                                            LeadHp -= BossAtk;

                                            //擦除上次显示的战斗信息
                                            Console.ForegroundColor = LeadColor;
                                            Console.SetCursorPosition(2, h - 5);
                                            Console.Write("                                             ");
                                            //显示这一次的战斗信息
                                            if (LeadHp <= 0)
                                            {
                                                Console.SetCursorPosition(2, h - 6);
                                                Console.Write("                                             ");
                                                Console.SetCursorPosition(2, h - 7);
                                                Console.Write("很遗憾，你没能战胜恶龙");
                                            }
                                            else
                                            {
                                                Console.SetCursorPosition(2, h - 5);
                                                Console.Write("Boss对你造成了{0}伤害，你的剩余血量为{1}", BossAtk, LeadHp);
                                            }
                                        }
                                        else
                                        {
                                            //擦除之前显示的战斗信息
                                            Console.SetCursorPosition(2, h - 7);
                                            Console.Write("                                             ");
                                            Console.SetCursorPosition(2, h - 6);
                                            Console.Write("                                             ");
                                            Console.SetCursorPosition(2, h - 5);
                                            Console.Write("                                             ");

                                            //显示战斗胜利显示的信息
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.SetCursorPosition(2, h - 7);
                                            Console.Write("恭喜你战胜了恶龙，快去营救公主吧!");
                                            Console.SetCursorPosition(2, h - 5);
                                            Console.Write("按J键继续");
                                        }
                                    }
                                }
                            }
                            //非战斗状态要做的事
                            else
                            {
                                //擦除主角移动前的位置
                                Console.SetCursorPosition(LeadX, LeadY);
                                Console.Write(" ");

                                #region 主角移动
                                switch (leadInput)
                                {
                                    case 'W':
                                    case 'w':
                                        LeadY--;
                                        if (LeadY < 1)
                                        {
                                            LeadY = 1;
                                        }
                                        else if (LeadX == BossX && LeadY == BossY && BossHp > 0)
                                        {
                                            LeadY++;
                                        }
                                        else if (LeadX == princessX && LeadY == princessY && BossHp <= 0)
                                        {
                                            LeadY++;
                                        }
                                        break;
                                    case 'A':
                                    case 'a':
                                        LeadX -= 2;
                                        if (LeadX < 2)
                                        {
                                            LeadX = 2;
                                        }
                                        else if (LeadX == BossX && LeadY == BossY && BossHp > 0)
                                        {
                                            LeadX += 2;
                                        }
                                        else if (LeadX == princessX && LeadY == princessY && BossHp <= 0)
                                        {
                                            LeadX += 2;
                                        }
                                        break;
                                    case 'S':
                                    case 's':
                                        LeadY++;
                                        if (LeadY > h - 9)
                                        {
                                            LeadY = h - 9;
                                        }
                                        else if (LeadX == BossX && LeadY == BossY && BossHp > 0)
                                        {
                                            LeadY--;
                                        }
                                        else if (LeadX == princessX && LeadY == princessY && BossHp <= 0)
                                        {
                                            LeadY--;
                                        }
                                        break;
                                    case 'D':
                                    case 'd':
                                        LeadX += 2;
                                        if (LeadX > w - 4)
                                        {
                                            LeadX = w - 4;
                                        }
                                        else if (LeadX == BossX && LeadY == BossY && BossHp > 0)
                                        {
                                            LeadX -= 2;
                                        }
                                        else if (LeadX == princessX && LeadY == princessY && BossHp <= 0)
                                        {
                                            LeadX -= 2;
                                        }
                                        break;
                                    //按J开始战斗
                                    case 'J':
                                    case 'j':
                                        if ((LeadX == BossX - 2 && LeadY == BossY ||
                                            LeadX == BossX + 2 && LeadY == BossY ||
                                            LeadX == BossX && LeadY == BossY + 1 ||
                                            LeadX == BossX && LeadY == BossY - 1) && BossHp > 0)
                                        {
                                            isFight = true;
                                            Console.SetCursorPosition(2, h - 7);
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.Write("按J键继续战斗");

                                            Console.SetCursorPosition(2, h - 6);
                                            Console.Write("Boss剩余血量为{0}", BossHp);

                                            Console.SetCursorPosition(2, h - 5);
                                            Console.Write("你的剩余血量为{0}", LeadHp);
                                        }
                                        else if ((LeadX == princessX - 2 && LeadY == princessY ||
                                                  LeadX == princessX + 2 && LeadY == princessY ||
                                                  LeadX == princessX && LeadY == princessY + 1 ||
                                                  LeadX == princessX && LeadY == princessY - 1) && BossHp <= 0)
                                        {
                                            backGround = 3;
                                            //好结局
                                            gameoverInfo = 1;
                                            //改变状态以跳出循环
                                            isEnd = true;
                                        }
                                        break;
                                }
                            }
                            #endregion
                            //跳出游戏场景
                            if (isEnd)
                            {
                                break;
                            }
                        }
                        break;

                    case 3:
                        #region 结束场景
                        Console.Clear();
                        //不变的文字
                        Console.SetCursorPosition(w / 2 - 5, 8);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Game  Over");

                        //根据结局不同显示不同的文字
                        if (gameoverInfo == 0)
                        {
                            Console.SetCursorPosition(w / 2 - 4, 10);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("Bad  End");
                        }
                        else
                        {
                            Console.SetCursorPosition(w / 2 - 5, 10);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("Happy  End");
                        }

                        int overSelect = 0;

                        bool ground3 = false;
                        //结局的选择
                        while (true)
                        {
                            Console.SetCursorPosition(w / 2 - 6, 15);
                            Console.ForegroundColor = overSelect == 0 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.Write("回到开始界面");

                            Console.SetCursorPosition(w / 2 - 4, 20);
                            Console.ForegroundColor = overSelect == 1 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.Write("退出游戏");

                            char overInput = Console.ReadKey(true).KeyChar;

                            switch (overInput)
                            {
                                case 'W':
                                case 'w':
                                    overSelect = 0;
                                    break;
                                case 'S':
                                case 's':
                                    overSelect = 1;
                                    break;
                                case 'J':
                                case 'j':
                                    if (overSelect == 0)
                                    {
                                        backGround = 1;
                                        ground3 = true;
                                    }
                                    else
                                    {
                                        Environment.Exit(0);
                                    }
                                    break;
                            }
                            if (ground3)
                            {
                                break;
                            }
                        }
                        #endregion
                        break;
                }
            }
        }
    }
}
