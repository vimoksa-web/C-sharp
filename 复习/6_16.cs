namespace _6_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //算术运算符
            //1.定义一个变量储存你的年龄，十年后你的年龄是多少，请输出到控制台
            //Console.WriteLine("请输入您的年龄：");
            //int age = Convert.ToInt32(Console.ReadLine());
            //age = age + 10;
            //Console.WriteLine("十年后您的年龄是{0}", age);

            //2.计算一个半径为5的圆的面积和周长
            //int r = 5;
            //float PI = 3.14f;
            //float Area = r * r * PI;
            //float Girth = 2 * r * PI;
            //Console.WriteLine($"半径为5的圆面积为{Area:f2},周长为{Girth:f2}");
            //Console.WriteLine("半径为5的圆面积为{0:f2},周长为{1:f2}", Area, Girth);

            //3.计算三门成绩的总分、平均分并打印到控制台，三门成绩均为整数类型
            //Console.WriteLine("请输入您的语文成绩：");
            //int Chinese = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入您的数学成绩：");
            //int Math = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入您的英语成绩：");
            //int English = Convert.ToInt32(Console.ReadLine());

            //int sum = Chinese + Math + English;
            //float avg = sum / 3f;
            //Console.WriteLine($"您的总分为{sum}，平均分为{avg:f1}");


            //4.商店T恤的价格为285元/件，裤子的价格为720元/条，小李在该店买了2件T恤和3条裤子，
            //请计算小李该付多少钱，打3.8折后呢？
            //int Cost = 285 * 2 + 720 * 3;
            //float Discount = 0.38f * Cost;
            //Console.WriteLine($"小李原本要付{Cost}元,打折后要付{Discount:f2}元");

            //5.请说明number1、number2和number3的计算结果
            //int a = 10, b = 20;
            //int number1 = ++a + b;//31
            //Console.WriteLine(number1);
            //a = 10;
            //b = 20;
            //int number2 = a + b++;//30
            //Console.WriteLine(number2);
            //a = 10;
            //b = 20;
            ////10 + 21 + 11
            //int number3 = a++ + ++b + a++;//42 第一个a被调用后先用后加，所以第二个a初始为11，先用后加变成12
            //Console.WriteLine(number3);

            //6.有两个数a=99,b=87,请写出两种方法交换它们的值,令a=87,b=99
            //int a = 99;
            //int b = 87;
            //int c = a;
            //a = b;
            //b = c;
            //Console.WriteLine($"a={a},b={b}");

            //a = 99;
            //b = 87;
            //a = a + b;// a = 99 + 87
            //b = a - b;// b = 99 + 87 -87 = 99
            //a = a - b;// a = 99 + 87 -99 = 87
            //Console.WriteLine($"a={a},b={b}");

            //a = 99;
            //b = 87;
            //(a, b) = (b, a);
            //Console.WriteLine($"a={a},b={b}");

            //7.请把987652秒通过代码转换为n天n时n分n秒显示在控制台中
            //int Time = 987652;
            //int oneDays = 24 * 60 * 60;//一天对应的秒数
            //int oneHours = 60 * 60;//一小时对应的秒数
            //int oneMinutes = 60;//一分钟的秒数

            //int Day = Time / oneDays;
            //int Hour = (Time % oneDays) / oneHours;//用不足一天的秒数 / 一小时对应的秒数
            //int Minute = (Time % oneHours) / oneMinutes;//不足一小时的秒数 / 一分钟对应的秒数
            //int Second = Time % 60;

            //Console.WriteLine(Day + "天" + Hour + "时" + Minute + "分" + Second + "秒");

            //TimeSpan ts = TimeSpan.FromSeconds(Time);
            //Console.WriteLine($"{ts.Days}天{ts.Hours}时{ts.Minutes}分{ts.Seconds}秒");


            //字符串拼接
            //1.定义一个变量储存用户的姓名，然后在屏幕上显示"你好，XXX" XXX表示用户的姓名
            //Console.WriteLine("请输入您的姓名：");
            //string name = Console.ReadLine();
            //Console.WriteLine("你好，{0}", name);

            //2.请用户输入用户名，年龄，班级，最后一起用占位符的形式打印出来
            //Console.WriteLine("请输入用户名：");
            //string userName = Console.ReadLine();
            //Console.WriteLine("请输入年龄：");
            //string userAge = Console.ReadLine();
            //Console.WriteLine("请输入班级：");
            //string userClass = Console.ReadLine();
            //Console.WriteLine("姓名：{0}，年龄：{1}，班级：{2}", userName, userAge, userClass);

            //string str = string.Format("姓名：{0}，年龄：{1}，班级：{2}", userName, userAge, userClass);
            //Console.WriteLine(str);


            //位运算符
            //1.33 << 4 和 66 >> 1 的结果为
            //int a = 33; //100001 << 4 = 1000010000 = 16 + 512 = 528
            //int b = 66; //1000010 >> 1 = 100001 = 1 + 32 = 33
            //Console.WriteLine(a << 4);
            //Console.WriteLine(b >> 1);

            ////2.99 ^ 33 和 76 | 85的结果为
            //a = 99;
            ////99 = 1100011
            ////33 = 0100001
            ////     1000010 = 66
            //b = 76;
            ////76 = 1001100
            ////85 = 1010101
            ////     1011101 = 93
            //Console.WriteLine(a ^ 33);
            //Console.WriteLine(b | 85);

            //逻辑运算符和三目运算符
            //1.比较两个数的大小，求出最大的
            //int a = 5;
            //int b = 10;
            //int i = a >= b ? a : b;
            //Console.WriteLine(i);

            //2.依次输入学生的姓名、C#的成绩、Unity的成绩，两门成绩都大于等于90才能毕业，请输出最后的结果
            //Console.WriteLine("请输入您的姓名：");
            //string Name = Console.ReadLine();
            //Console.WriteLine("请输入您的C#成绩：");
            //int scoreCsharp = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入您的Unity成绩：");
            //int scoreUnity = int.Parse(Console.ReadLine());

            //Console.WriteLine(scoreCsharp >= 90 && scoreUnity >= 90 ? "可以毕业" : "不能毕业");


            //if语句
            //1.请用户输入今日看视频花了多少分钟，如果大于60分钟，那么在控制台输入"今天学习了XX分钟，看来你离成功又近了一步!"
            //Console.WriteLine("你今天看视频花了多少分钟：");
            //int minutes = int.Parse(Console.ReadLine());
            //if (minutes > 60)
            //    Console.WriteLine($"今天学习了{minutes}分钟，看来你离成功又近了一步");
            //else
            //    Console.WriteLine("继续努力");

            //Console.WriteLine(minutes > 60 ? $"今天学习了{minutes}分钟，看来你离成功又近了一步" : "继续努力");


            //2.请输入你的语文、数学、英语成绩，满足以下任一条件，则输出"非常棒，继续加油"
            //语文成绩大于70并且数学成绩大于80并且英语成绩大于90
            //语文成绩等于100或者数学成绩等于100或者英语成绩等于100
            //语文成绩大于90并且其他两门中有一门成绩大于70
            //Console.WriteLine("请输入您的语文成绩：");
            //int Chinese = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入您的数学成绩：");
            //int Math = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入您的英语成绩：");
            //int English = int.Parse(Console.ReadLine());
            //if ((Chinese > 70 && Math > 80 && English > 90) ||
            //   (Chinese == 100 || Math == 100 || English == 100) ||
            //   (Chinese > 90 && (Math > 70 || English > 70)))
            //    Console.WriteLine("非常棒，继续加油");
            //else
            //    Console.WriteLine("不要灰心，继续努力");

            //3.提示用户输入用户名，然后再提示输入密码，如果用户名是"admin"，并且密码是"8888"，
            //则提示正确，否则，如果用户名不是admin提示用户名不存在，如果用户名是admin则提示密码错误
            //Console.WriteLine("请输入用户名：");
            //string username = Console.ReadLine();
            //Console.WriteLine("请输入密码：");
            //string password = Console.ReadLine();
            //if (username == "admin" && password == "8888")
            //    Console.WriteLine("登录成功");
            //else if (username != "admin")
            //    Console.WriteLine("用户名不存在");
            //else
            //    Console.WriteLine("密码错误");

            //4.提示用户输入年龄，如果大于等于18，则告知用户可以查看，如果小于13岁，则告知不允许查看，如果大于等于13并且小于18，则提示用户是否继续查看(yes,no)，如果输入的是yes则提示"用户请查看"，否则提示"退出"
            //Console.WriteLine("请输入您的年龄：");
            //int Age = int.Parse(Console.ReadLine());
            //if (Age >= 18)
            //{
            //    Console.WriteLine("可以查看");
            //}
            //else if (Age >= 13 && Age < 18)
            //{
            //    Console.WriteLine("是否要继续查看(yes,no)");
            //    string str = Console.ReadLine();
            //    if (str == "yes")
            //        Console.WriteLine("用户请查看");
            //    else if (str == "no")
            //        Console.WriteLine("退出");
            //    else
            //        Console.WriteLine("请输入正确字符");
            //}
            //else
            //{
            //    Console.WriteLine("不允许查看");
            //}


            //switch语句
            //1.老师的工资是由基本工资 + 绩效决定的
            //绩效说明：
            //学生评价很兴奋 则评定为A级 绩效工资500
            //学生评价很充实 则评定为B级 不加绩效工资
            //学生评价还好吧 则评定为C级 绩效工资扣300
            //学生评价难理解 则评定为D级 绩效工资扣500
            //学生评价枯燥乏味 则评定为E级 绩效工资扣800
            //假设王老师的工资是4000，请输入王老师的评级，并算出王老师的工资是多少
            //int wages = 4000;
            //Console.WriteLine("请输入王老师的评级：");
            //char performance = char.Parse(Console.ReadLine());
            //switch(performance)
            //{
            //    case 'A':
            //        wages += 500;
            //        break;
            //    case 'C':
            //        wages -= 300;
            //        break;
            //    case 'D':
            //        wages -= 500;
            //        break;
            //    case 'E':
            //        wages -= 800;
            //        break;
            //    default:
            //        Console.WriteLine("请输入正确的评级");
            //        return;
            //}
            //Console.WriteLine($"王老师的工资是{wages}元");

            //int wages = 4000;
            //try
            //{
            //    Console.WriteLine("请输入王老师的评级：");
            //    char performance = char.ToUpper(char.Parse(Console.ReadLine()));

            //    int bonus = performance switch
            //    {
            //        'A' => 500,
            //        'B' => 0,
            //        'C' => -300,
            //        'D' => -500,
            //        'E' => -800,
            //        _ => throw new Exception()
            //    };
            //    Console.WriteLine($"王老师的工资是{wages + bonus}元");
            //}
            //catch
            //{
            //    Console.WriteLine("请输入正确的评级(A-E)");
            //}


            //2.小唐带了10元去买星巴克，有三种规格可以选择
            //1 = (中杯 ￥5)
            //2 = (大杯 ￥7)
            //3 = (超大杯 ￥11)
            //请用户输入选择的规格，如果钱够则购买成功，并算出小唐最后还剩多少钱
            //如果钱不够，则提示用户"钱不够，请选择其他规格"
            //int money = 10;
            //try
            //{
            //    Console.WriteLine("请选择你要购买的规格(1/2/3)");
            //    int select = int.Parse(Console.ReadLine());
            //    int price = select switch
            //    {
            //        1 => 5,
            //        2 => 7,
            //        3 => 11,
            //        _ => throw new Exception()
            //    };
            //    if (money >= price)
            //        Console.WriteLine($"购买成功，还剩{money - price}元");
            //    else
            //        Console.WriteLine("钱不够，请选择其他规格");
            //}
            //catch
            //{
            //    Console.WriteLine("请选择正确的规格");
            //}

            //3.输入学生的考试成绩，如果成绩>=90：A
            //90 > 成绩 >= 80: B
            //80 > 成绩 >= 70: C
            //70 > 成绩 >= 60: D
            //成绩 < 60: E
            //使用switch语句完成，最后输出学生的考试等级
            //try
            //{
            //    Console.WriteLine("请输入学生的考试成绩：");
            //    int Score = int.Parse(Console.ReadLine());
            //    if (Score < 0 || Score > 100)
            //    {
            //        throw new Exception();
            //    }
            //    Score /= 10;
            //    char grade = Score switch
            //    {
            //        10 => 'A',
            //        9 => 'A',
            //        8 => 'B',
            //        7 => 'C',
            //        6 => 'D',
            //        _ => 'E'
            //    };
            //    Console.WriteLine($"学生的考试等级为{grade}");
            //}
            //catch
            //{
            //    Console.WriteLine("请输入正确的格式");
            //}


            //try
            //{
            //    Console.WriteLine("请输入学生的考试成绩：");
            //    int Score = int.Parse(Console.ReadLine());
            //    char grade = Score switch
            //    {
            //        < 0 or > 100 => throw new Exception(),
            //        >= 90 => 'A',
            //        >= 80 => 'B',
            //        >= 70 => 'C',
            //        >= 60 => 'D',
            //        _ => 'E'
            //    };
            //    Console.WriteLine($"学生的考试等级为{grade}");
            //}catch
            //{
            //    Console.WriteLine("请输入正确的格式");
            //}

            //4.在控制台输入一个0~9的数并显示为大写。如输入2，则显示二
            try
            {
                Console.WriteLine("请输入一个0~9的数字");
                int i = int.Parse(Console.ReadLine());
                char c = i switch
                {
                    0 => '零',
                    1 => '一',
                    2 => '二',
                    3 => '三',
                    4 => '四',
                    5 => '五',
                    6 => '六',
                    7 => '七',
                    8 => '八',
                    9 => '九',
                    _ => throw new Exception()
                };
                Console.WriteLine(c);
            }catch
            {
                Console.WriteLine("请输入正确的格式");
            }

        }
    }
}
