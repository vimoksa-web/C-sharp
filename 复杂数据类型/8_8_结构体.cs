using Microsoft.VisualBasic;
using System.Security.Cryptography;
using System.Threading;

namespace Test8_8
{
    #region 第一题
    //1.使用结构体描述学员的信息，姓名、性别、年龄、班级、专业，创建两个学员对象，
    //并对其基本信息进行初始化并打印
    struct Student
    {
        public string name;
        public char sex;
        public int age;
        public int banji;
        public string zhuanye;

        public Student(string name, char sex, int age, int banji, string zhuanye)
        {
            this.name = name;
            this.sex = sex;
            this.age = age;
            this.banji = banji;
            this.zhuanye = zhuanye;
        }
        public void Information()
        {
            Console.WriteLine("姓名：{0} 性别：{1} 年龄：{2} 班级：{3} 专业：{4}", name, sex, age, banji, zhuanye);
        }
    }
    #endregion

    #region 第二题
    //2.请简要描述private和public两个关键字的区别
    //public：公共的，可以让结构体中的变量或方法被外部使用
    //private：私有的，结构体中的变量或方法只能在内部使用，如果没有声明关键字，默认为private
    #endregion

    #region 第三题
    //3.使用结构体描述矩阵的信息，长、宽；创建一个矩形，对其长宽进行初始化，并打印
    //矩形的长、宽、面积、周长等信息
    struct Rectangle
    {
        public int length;
        public int width;
        public int area;
        public int girth;

        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
            area = length * width;
            girth = 2 * (length + width);
        }

        public void Fun1()
        {
            Console.WriteLine("矩形长{0} 宽{1} 周长{2} 面积{3}", length, width, girth, area);
        }
    }
    #endregion

    #region 第四题
    //4.请使用结构体描述玩家信息，玩家名字，玩家职业
    //请用户输入玩家姓名，选择玩家职业，最后打印玩家的攻击信息职业：
    //战士（技能：冲锋）
    //猎人（技能：翻滚）
    //法师（技能：奥术冲击）
    //打印结果：猎人XXX释放了翻滚
    struct Player
    {
        public string playerName;
        public string playerOccu;
        public string playerSkill;

        public Player()
        {
            Console.WriteLine("请输入玩家姓名：");
            playerName = Console.ReadLine();
            Console.WriteLine("请选择职业(战士1/猎人2/法师3)");
            int select = int.Parse(Console.ReadLine());
            switch (select)
            {
                case 1:
                    playerOccu = "战士";
                    playerSkill = "冲锋";
                    break;
                case 2:
                    playerOccu = "猎人";
                    playerSkill = "翻滚";
                    break;
                case 3:
                    playerOccu = "法师";
                    playerSkill = "奥术冲击";
                    break;
            }
        }
        public void Fun2()
        {
            Console.WriteLine("{0}{1}释放了{2}", playerOccu, playerName, playerSkill);
        }
    }

    struct PlayerInfo
    {
        public string name;
        public E_Occu occu;

        public PlayerInfo(string name, E_Occu occu)
        {
            this.name = name;
            this.occu = occu;
        }

        public void Atk()
        {
            string playerOccu = "";
            string playerSkill = "";
            switch (occu)
            {
                case E_Occu.Warrior:
                    playerOccu = "战士";
                    playerSkill = "冲锋";
                    break;
                case E_Occu.Hunter:
                    playerOccu = "猎人";
                    playerSkill = "翻滚";
                    break;
                case E_Occu.Master:
                    playerOccu = "法师";
                    playerSkill = "奥术冲击";
                    break;
            }
            Console.WriteLine("{0}{1}释放了{2}", playerOccu, name, playerSkill);
        }
    }

    enum E_Occu
    {
        Warrior,
        Hunter,
        Master
    }
    #endregion

    #region 第五题
    //5.使用结构体描述怪兽
    struct Monster
    {
        public string monsterName;
        public int monsterAtk;

        public Monster(string monsterName)
        {
            this.monsterName = monsterName;
            Random r = new Random();
            monsterAtk = r.Next(1, 11);
        }

        public void MonsterAtk()
        {
            Console.WriteLine("{0}，攻击力为{1}", monsterName, monsterAtk);
        }
    }
    #endregion

    #region 第六题
    //6.定义一个数组存储10个上面描述的怪兽，每个怪兽的名字为（怪兽 + 数组下标）
    //举例：怪兽0，攻击力为10
    
    #endregion

    #region 第七题
    //7.应用已学过的知识，实现奥特曼打怪兽
    //提示：
    //结构体描述奥特曼与怪兽
    //定义一个方法实现奥特曼攻击怪兽
    //定义一个方法实现怪兽攻击奥特曼
    struct Ultraman
    {
        public string ultramanName;
        public int ultramanAtk;
        public int ultramanDef;
        public int ultramanHp;

        public Ultraman(string ultramanName, int ultramanAtk, int ultramanDef, int ultramanHp)
        {
            this.ultramanName = ultramanName;
            this.ultramanAtk = ultramanAtk;
            this.ultramanDef = ultramanDef;
            this.ultramanHp = ultramanHp;
        }
        //因为结构体是值类型，如果想要在函数内部改变值，一定要用ref和out
        public void UAtk(ref Boss monster)
        {
            monster.BossHp -= ultramanAtk - monster.BossDef;
            Console.WriteLine("奥特曼对怪兽造成了{0}伤害,怪兽剩余{1}血", ultramanAtk - monster.BossDef, monster.BossHp);
        }

    }
    struct Boss
    {
        public string BossName;
        public int BossAtk;
        public int BossDef;
        public int BossHp;

        public Boss(string BossName, int BossAtk, int BossDef, int BossHp)
        {
            this.BossName = BossName;
            this.BossAtk = BossAtk;
            this.BossDef = BossDef;
            this.BossHp = BossHp;
        }

        public void BAtk(ref Ultraman ultraman)
        {
            ultraman.ultramanHp -= BossAtk - ultraman.ultramanDef;
            Console.WriteLine("怪兽对奥特曼造成了{0}伤害,奥特曼剩余{1}血", BossAtk - ultraman.ultramanDef, ultraman.ultramanHp);
        }

    }
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            //Student s1 = new Student("WXD", '男', 23, 2, "软件工程");
            //s1.Information();
            //Student s2 = new Student("ABC", '女', 23, 2, "数字媒体");
            //s2.Information();

            //3.
            //Rectangle r1 = new Rectangle(8, 6);
            //r1.Fun1();

            //4.
            //Player p1 = new Player();
            //p1.Fun2();

            //Console.WriteLine("请输入您的名字：");
            //string name = Console.ReadLine();
            //try
            //{
            //    Console.WriteLine("请选择您的职业(0战士 1猎人 2法师)");
            //    E_Occu occu = (E_Occu)int.Parse(Console.ReadLine());
            //    PlayerInfo p2 = new PlayerInfo(name, occu);
            //    p2.Atk();
            //}
            //catch
            //{
            //    Console.WriteLine("请输入数字");
            //}

            //6.
            //Monster[] monsters = new Monster[10];
            //for (int i = 0; i < monsters.Length; i++)
            //{
            //    monsters[i] = new Monster("怪兽" + i);
            //    monsters[i].MonsterAtk();
            //}

            //7.
            Random random = new Random();
            int ultramanAtk = random.Next(10,25);
            Ultraman ultraman = new Ultraman("杰克奥特曼", ultramanAtk, 5, 100);

            int monsterAtk = random.Next(15,20);
            Boss boss = new Boss("触手怪", monsterAtk, 6, 100);

            while (true)
            {
                ultraman.UAtk(ref boss);
                if (boss.BossHp <= 0)
                {
                    Console.WriteLine("{0}打败了{1}", ultraman.ultramanName, boss.BossName);
                    break;
                }
                boss.BAtk(ref ultraman);
                if (ultraman.ultramanHp <= 0)
                {
                    Console.WriteLine("{0}打败了{1}", boss.BossName, ultraman.ultramanName);
                    break;
                }
                Console.WriteLine("按任意键继续");
                Console.ReadKey(true);
            }
            
        }
    }
}
