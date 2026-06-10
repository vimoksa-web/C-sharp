namespace C_6_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //请使用至少两种方式打印出：
            //我是小明
            //我今年18岁
            //我的爱好是制作游戏
            //好好学习，天天向上
            //Console.WriteLine("我是小明");
            //Console.WriteLine("我今年18岁");
            //Console.WriteLine("我的爱好是制作游戏");
            //Console.WriteLine("好好学习，天天向上");

            //Console.WriteLine("------------------------------");

            //Console.Write("我是小明\n我今年18岁\n我的爱好是制作游戏\n好好学习，天天向上\n");

            //Console.WriteLine("------------------------------");

            //Console.WriteLine("我是小明\n我今年18岁\n我的爱好是制作游戏\n好好学习，天天向上");

            //Console.WriteLine("------------------------------");

            //Console.Write("我是小明\n");
            //Console.Write("我今年18岁\n");
            //Console.Write("我的爱好是制作游戏\n");
            //Console.Write("好好学习，天天向上\n");


            //将自己的名字的每一个字符转换成数字并打印出来
            //int a = '魏';
            //int b = '向';
            //int c = '东';
            //Console.WriteLine("自己名字对应的ASCII值为：" + a + b + c);

            //1.下面代码的输出结果是：
            //double num = 36.6;
            //Console.WriteLine(num);

            //2.定义一系列变量用来存储你的姓名，年龄，身高，体重，家庭住址，并打印出来
            //string name = "WXD";
            //int age = 24;
            //int height = 172;
            //int weight = 80;
            //string adress = "郑州";
            //Console.WriteLine("我是" + name + ",今年" + age + "岁,身高" + height + "cm,体重" + weight + "kg,家住在" + adress );
            //Console.WriteLine("我是{0},今年{1}岁,身高{2}cm,体重{3}kg,家住在{4}", name, age, height, weight, adress);
            //Console.WriteLine($"我是{name},今年{age}岁,身高{height}cm,体重{weight}kg,家住在{adress}");

            //3.小明的数学成绩是80，语文成绩是78，英语成绩是98，请用变量描述并打印
            //int Math = 80;
            //int Chinese = 78;
            //int English = 98;
            //Console.WriteLine($"小明的数学成绩是{Math},语文成绩是{Chinese},英语成绩是{English}");

            //1.请用户输入姓名，年龄，班级
            //Console.WriteLine("请输入您的姓名：");
            //string name = Console.ReadLine();
            //Console.WriteLine("请输入您的年龄：");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入您的班级：");
            //string banji = Console.ReadLine();
            //Console.WriteLine($"您的姓名是{name},年龄是{age},班级是{banji}");
            //Console.WriteLine("请按任意键确认");
            //Console.ReadKey();
            //Environment.Exit(0);

            //2.问用户喜欢什么运动，用户输入什么，回复"哈哈，好巧，我也喜欢这个运动"
            //Console.WriteLine("您喜欢什么运动");
            //string sports = Console.ReadLine();
            //if (sports == "足球")
            //    Console.WriteLine("哈哈，好巧，我也喜欢这个运动");
            //else
            //    Console.WriteLine("我更喜欢足球");

            //3.输入10*10的空心*矩形
            //Console.WriteLine("**********");
            //Console.WriteLine("*        *");
            //Console.WriteLine("*        *");
            //Console.WriteLine("*        *");
            //Console.WriteLine("*        *");
            //Console.WriteLine("*        *");
            //Console.WriteLine("*        *");
            //Console.WriteLine("*        *");
            //Console.WriteLine("*        *");
            //Console.WriteLine("**********");

            //for(int i = 1; i <= 10; i++)
            //{
            //    if (i == 1 || i == 10)
            //        Console.WriteLine("**********");
            //    else
            //        Console.WriteLine("*        *");
            //}

            //int n = 10;
            //for(int i = 1; i <= n; i++)
            //{
            //    for(int j = 1; j <= n;j++)
            //    {
            //        if (i == 1 || i == n || j == 1 || j == n)
            //            Console.Write("*");
            //        else
            //            Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}

            //1.请将24069转成字符并打印
            //char num = (char)24069;
            //Console.WriteLine(num);

            //num = Convert.ToChar(24069);
            //Console.WriteLine(num);

            //2.提示用户输入姓名、语文、数学、英语成绩，并将输入的成绩用整型变量储存
            //Console.WriteLine("请输入您的姓名：");
            //string name = Console.ReadLine();

            //Console.WriteLine("请输入您的语文成绩：");
            //int Chinese = Convert.ToInt32 (Console.ReadLine());
            //Console.WriteLine("请输入您的数学成绩：");
            //int Math = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入您的英语成绩：");
            //int English = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"您好，{name}，您的语文成绩是{Chinese}，数学成绩是{Math}，英语成绩是{English}");

            //1.请用户输入一个数字，如果输入有错，则提示用户输入错误
            //Console.WriteLine("请输入一个数字：");
            //try
            //{
            //    long i = long.Parse(Console.ReadLine());
            //    Console.WriteLine(i);
            //}catch
            //{
            //    Console.WriteLine("输入错误，请输入合法数字");
            //}

            //2.提示用户输入姓名、语文、数学、英语成绩，如果输入的成绩有误，则提示用户输入错误，否则将输入的字符串转为整型变量存储

            //第一种
            //Console.WriteLine("请输入您的姓名：");
            //string name = Console.ReadLine();
            //try
            //{
            //    Console.WriteLine("请输入您的语文成绩：");
            //    int Chinese = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("请输入您的数学成绩：");
            //    int Math = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("请输入您的英语成绩：");
            //    int English = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine($"您好，{name}，您的语文成绩是{Chinese}，数学成绩是{Math}，英语成绩是{English}");
            //}
            //catch
            //{
            //    Console.WriteLine("您输入的成绩有误，请输入正确成绩");
            //}

            //第二种
            //Console.WriteLine("请输入您的姓名：");
            //string name = Console.ReadLine();
            //int Chinese = 0;
            //int Math = 0;
            //int English = 0;

            //while (true)
            //{
            //    Console.WriteLine("请输入您的语文成绩：");
            //    if (int.TryParse(Console.ReadLine(), out Chinese) && Chinese >= 0 && Chinese <= 100)
            //        break;
            //    Console.WriteLine("您输入的成绩有误，请输入0-100之间的正确成绩");
            //}
            //while (true)
            //{
            //    Console.WriteLine("请输入您的数学成绩：");
            //    if (int.TryParse(Console.ReadLine(), out Math) && Math >= 0 && Math <= 100)
            //        break;
            //    Console.WriteLine("您输入的成绩有误，请输入0-100之间的正确成绩");
            //}
            //while (true)
            //{
            //    Console.WriteLine("请输入您的英语成绩：");
            //    if (int.TryParse(Console.ReadLine(), out English) && English >= 0 && English <= 100)
            //        break;
            //    Console.WriteLine("您输入的成绩有误，请输入0-100之间的正确成绩");
            //}
            //Console.WriteLine($"您好，{name}，您的语文成绩是{Chinese}，数学成绩是{Math}，英语成绩是{English}");

            //第三种
            Console.WriteLine("请输入您的姓名：");
            string name = Console.ReadLine();

            int Chinese = SubjectScore("语文");
            int Math = SubjectScore("数学");
            int English = SubjectScore("英语");

            Console.WriteLine($"您好，{name}，您的语文成绩是{Chinese}，数学成绩是{Math}，英语成绩是{English}");

        }

        static int SubjectScore(string SubjectName)
        {
            while (true)
            {
                Console.WriteLine("请输入您的{0}成绩", SubjectName);
                if (int.TryParse(Console.ReadLine(), out int score) && score >= 0 && score <= 100)
                    return score;
                Console.WriteLine("您输入的成绩有误，请输入0-100之间的正确成绩");
            }
        }
    }
}
