namespace test7_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.用while循环打印1~20之间的奇数
            //int i = 0;
            //while ( i < 20)
            //{
            //    ++i;
            //    if (i % 2 == 1)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    else
            //        continue;
            //}

            //2.在控制台输出1~100
            //int i = 0;
            //while ( i < 100)
            //{
            //    i++;
            //    Console.WriteLine(i);
            //}

            //3.在控制台输出1~100之间所有整数的和
            //int i = 0;
            //int sum = 0;
            //while ( i < 100)
            //{
            //    i++;
            //    sum += i;
            //}
            //Console.WriteLine(sum);

            //4.用while和continue实现1~100(包含)之间的除了能被7整除之外的所有整数的和
            //int i = 0;
            //int sum = 0;
            //while (i < 100)
            //{
            //    i++;
            //    if ( i % 7 == 0)
            //    {
            //        continue;
            //    }
            //    sum += i;
            //}
            //Console.WriteLine(sum);

            //5.提示用户输入一个数，判断该数是否是素数并打印
            //素数/质数：只能被1和这个数字本身整除的数字，1不是质数，最小的质数是2
            //try
            //{
            //    Console.WriteLine("请输入一个整数：");
            //    int i = int.Parse(Console.ReadLine());
            //    int j = 2;
            //    while (i > j)
            //    {
            //        if (i % j == 0)
            //        {
            //            break;
            //        }
            //        ++j;
            //    }
            //    if (i != j)
            //    {
            //        Console.WriteLine("{0}不是素数", i);
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0}是素数", i);
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("请输入数字");
            //}

            //6.要求输入用户名和密码(admin/8888)，用户名或者密码错误，则提示“用户名或密码错误，直到输入正确为止”
            //while (true)
            //{
            //    Console.WriteLine("请输入用户名：");
            //    string userName = Console.ReadLine();
            //    Console.WriteLine("请输入密码：");
            //    string passWord = Console.ReadLine();
            //    if (userName != "admin" || passWord != "8888")
            //    {
            //        Console.WriteLine("用户名或密码错误，请继续输入");
            //    }
            //    else
            //    {
            //        Console.WriteLine("登陆成功");
            //        break;
            //    }
            //}

            //7.输入班级人数，然后依次输入学员成绩（需提示当前是第几个学员），计算班级学员的平均成绩和总成绩
            //try
            //{
            //    Console.WriteLine("请输入班级人数：");
            //    int classPerson = int.Parse(Console.ReadLine());
            //    int i = 1;
            //    int sum = 0;
            //    while (classPerson >= i)
            //    {
            //        Console.WriteLine("请输入第{0}个学员成绩", i);
            //        int score = int.Parse(Console.ReadLine());
            //        ++i;
            //        sum += score;
            //    }
            //    Console.WriteLine("班级学员的总成绩为{0}", sum);
            //    Console.WriteLine("班级学员的总成绩为{0}", sum / classPerson);
            //}
            //catch
            //{
            //    Console.WriteLine("请输入数字");
            //}

            //8.定义一个整型变量sum，然后分别把1~100之间的数字依次累加到sum中，
            //当sum的值大于500的时候中断操作，并在控制台输出累加到第几个数字就可以使sum大于500
            //int sum = 0;
            //int i = 0;
            //while (i < 100)
            //{
            //    i++;
            //    sum += i;
            //    if (sum > 500)
            //    {
            //        Console.WriteLine("当累加到{0}就会使sum大于500", i);
            //        break;
            //    }
            //}

            //9.假设看视频的同学有100人，每个月增长20%，请问按此速度增长，经历多少个月看视频的同学能达到1000人？
            //float f = 100;
            //int month = 0;
            //while (true)
            //{
            //    month++;
            //    f += 0.2f * f;
            //    int classMate = Convert.ToInt32(f);
            //    if (classMate >= 1000)
            //    {
            //        Console.WriteLine("经历{0}个月看视频的同学达到1000人", month);
            //        break;
            //    }
            //}

            //10.求数列1，1，2，3，5，8，13....的第二十位的数字是多少？(斐波那契数列)
            //2 = 1 + 1
            //3 = 2 + 1
            //5 = 3 + 2
            //int i = 1;
            //int j = 1;
            //int num = i + j;
            //int x = 3;
            //while (x < 20)
            //{
            //    x++;
            //    i = j;
            //    j = num;
            //    num = i + j;
            //    Console.WriteLine("第{0}位的数字是{1}", x, num);
            //}

            //11.找出100内所有素数并打印
            int i = 2;
            while (i < 100)
            {
                int j = 2;
                while (i > j)
                {
                    if (i % j == 0)
                    {
                        break;
                    }
                    j++;
                }
                if (i == j)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
    }
}
