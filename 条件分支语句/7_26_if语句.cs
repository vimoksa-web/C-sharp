namespace test7_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.请用户输入今日看视频花了多少分钟，如果大于60分钟，那么在控制台输入"今天学习了XX分钟，看来你离成功又近了一步!"
            //Console.WriteLine("你今天看了多长时间的视频");
            //int watchVideo = int.Parse(Console.ReadLine());
            //if (watchVideo > 60)
            //{
            //    Console.WriteLine("你今天学习了{0}分钟，看来你离成功又近了一步!" , watchVideo);
            //}

            //2.请输入你的语文、数学、英语成绩，满足以下任一条件，则输出"非常棒，继续加油"
            //语文成绩大于70并且数学成绩大于80并且英语成绩大于90
            //语文成绩等于100或者数学成绩等于100或者英语成绩等于100
            //语文成绩大于90并且其他两门中有一门成绩大于70
            //Console.WriteLine("请输入你的语文成绩");
            //int Chinese = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入你的数学成绩");
            //int Math = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入你的英语成绩");
            //int English = int.Parse(Console.ReadLine());

            //if ((Chinese > 70 && Math > 80 && English > 90) || 
            //    (Chinese == 100 || Math == 100 || English == 100) || 
            //    (Chinese > 90 && (Math > 70 || English > 70)))
            //{
            //    Console.WriteLine("非常棒，继续加油");
            //}
            //else 
            //{
            //    Console.WriteLine("下次继续努力");
            //}

            //3.定义一个变量，存储小赵的考试成绩，如果小赵的考试成绩大于(含)90分，那么爸爸奖励100元，否则一个月不能玩游戏
            //Console.WriteLine("请输入考试成绩：");
            //int Score = int.Parse(Console.ReadLine());
            //if (Score >= 90)
            //{
            //    Console.WriteLine("爸爸奖励100元");
            //}
            //else
            //{
            //    Console.WriteLine("一个月不能玩游戏");
            //}

            //4.要求用户输入两个数a,b，如果两个数可以整除或者这两个数加起来大于100，则输出a的值，否则输出b的值
            //Console.WriteLine("请输入a和b的值");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //if (a % b == 0 || b % a == 0 || a + b > 100)
            //{
            //    Console.WriteLine(a);
            //}
            //else
            //{
            //    Console.WriteLine(b);
            //}

            //5.输入一个整数，如果这个数是偶数，则打印"Your input is even"，否则打印"Your input is odd"
            //Console.WriteLine("请输入一个整数：");
            //int i = int.Parse(Console.ReadLine());
            //if (i % 2 == 0)
            //    Console.WriteLine("Your input is even");
            //else
            //    Console.WriteLine("Your input is odd");

            //6.有三个整型变量，分别存储不同的值，编写代码输出其中最大的整数
            //int x = 20, y = 10, z = 11;
            //if (x > y && x > z)
            //    Console.WriteLine(x);
            //else if (y > x && y > z)
            //    Console.WriteLine(y);
            //else
            //    Console.WriteLine(z);

            //7.写一个程序接受用户输入的数字，如果输入的字符是0~9数字中的一个，则显示"您输入了一个数字",否则显示"这不是一个数字"
            //Console.WriteLine("请输入一个数字：");
            //float f = float.Parse(Console.ReadLine());
            //if (f >= 0 && f <= 9)
            //    Console.WriteLine("您输入了一个数字");
            //else
            //    Console.WriteLine("这不是一个数字");

            //8.提示用户输入用户名，然后再提示输入密码，如果用户名是"admin"，并且密码是"8888"，则提示正确，否则，如果用户名不是admin提示用户名不存在，如果用户名是admin则提示密码错误
            //Console.WriteLine("请输入用户名：");
            //string userName = Console.ReadLine();
            //Console.WriteLine("请输入密码：");
            //string passWord = Console.ReadLine();
            //if (userName == "admin" && passWord == "8888")
            //    Console.WriteLine("登录成功");
            //else if (userName != "admin")
            //    Console.WriteLine("用户名不存在");
            //else
            //    Console.WriteLine("密码错误");

            //9.提示用户输入年龄，如果大于等于18，则告知用户可以查看，如果小于13岁，则告知不允许查看，如果大于等于13并且小于18，则提示用户是否继续查看(yes,no)，如果输入的是yes则提示"用户请查看"，否则提示"退出"
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
            //}
            //else
            //{
            //    Console.WriteLine("不允许查看");
            }
        }
    }
}
