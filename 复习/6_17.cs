namespace _6_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //do...while循环
            ////1.要求用户输入用户名和密码，只要不是admin和8888就一直提示用户名或密码错误，请重新输入
            //do
            //{
            //    Console.WriteLine("请输入用户名：");
            //    string userName = Console.ReadLine();
            //    Console.WriteLine("请输入密码：");
            //    string passWord = Console.ReadLine();
            //    if(userName == "admin" && passWord == "8888")
            //    {
            //        Console.WriteLine("登录成功");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("用户名或密码错误");
            //    }
            //}while (true);

            ////2.不断提示请输入你的姓名，直到输入q结束
            //string name = "";
            //do
            //{
            //    Console.WriteLine("请输入你的姓名：");
            //    name = Console.ReadLine();
            //} while (name != "q");


            //for循环
            //1.输出1~100之间的整数(含100)
            //for(int i = 1; i <= 100; i++)
            //{
            //    Console.Write(i+" ");
            //}

            //2.求1~100之间所有偶数的和
            //int count = 0;
            //for(int i = 2; i <= 100; i+= 2)
            //{
            //    Console.WriteLine(i + " ");
            //    count += i;
            //}
            //Console.WriteLine(count);

            //3.找出100~999之间的水仙花数
            //例如：153 = 1*1*1 + 5*5*5 + 3*3*3，这个数就是水仙花数
            //for(int i = 100; i < 1000; i++)
            //{
            //    int n1 = i / 100;
            //    int n2 = (i % 100) / 10;
            //    int n3 = i % 10;
            //    if (i == n1 * n1 * n1 + n2 * n2 * n2 + n3 * n3 * n3)
            //        Console.WriteLine(i);
            //}

            //4.在控制台输出九九乘法表
            //for (int i = 1; i < 10; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write($"{i} * {j} = {i*j}" + " ");
            //    }
            //    Console.WriteLine();
            //}

            //5.在控制台上输出10*10的空心星型方阵
            //for(int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        if (i == 1 || i == 10)
            //            Console.Write("*");
            //        else
            //        {
            //            if (j == 1 || j == 10)
            //                Console.Write("*");
            //            else
            //                Console.Write(" ");
            //        }
            //    }
            //    Console.WriteLine();
            //}


            //6.在控制台上输出10*10的三角形方阵
            //for(int i = 1;i<=10;i++)
            //{
            //    for(int j = 1;j<=i;j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            //7.在控制台上输出10行的等腰三角形方阵
            //行
            //for (int i = 1; i <= 10; i++)
            //{
            //    //打印空格的列
            //    for (int j = 0; j < 10 - i; j++)
            //    {
            //        Console.Write(" ");
            //    }

            //    //打印星号的列
            //    for (int k = 0; k < 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            //while循环
            //1.用while循环打印1~20之间的奇数
            //int i = 1;
            //while(i <= 20)
            //{
            //    if (i % 2 != 0)
            //        Console.WriteLine(i);
            //        i+=2;
            //}


            //2.在控制台输出1~100之间所有整数的和
            //int i = 1;
            //int sum = 0;
            //while(i<=100)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);


            //3.用while和continue实现1~100(包含)之间的除了能被7整除之外的所有整数的和
            //int i = 0;
            //int sum = 0;
            //while(i<100)
            //{
            //    i++;
            //    if (i % 7 == 0)
            //        continue;

            //    sum += i;
            //}
            //Console.WriteLine(sum);


            //4.定义一个整型变量sum，然后分别把1~100之间的数字依次累加到sum中，
            //当sum的值大于500的时候中断操作，并在控制台输出累加到第几个数字就可以使sum大于500
            //int i = 1;
            //int sum = 0;
            //while(i<=100)
            //{
            //    if (sum > 500)
            //        break;
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine($"累加到第{i}个数字就可以使sum大于500");


            //5.假设看视频的同学有100人，每个月增长20%，请问按此速度增长，经历多少个月看视频的同学能达到1000人？
            //float f = 100;
            //int month = 0;
            //int classmate = 0;
            //while (true)
            //{
            //    month++;
            //    f += f * 0.2f;
            //    classmate = Convert.ToInt32(f);
            //    if (classmate >= 1000)
            //    {
            //        Console.WriteLine($"经历{month}个月看视频的同学能达到1000人");
            //        break;
            //    }
            //}

            //6.求数列1，1，2，3，5，8，13....的第二十位的数字是多少？(斐波那契数列)
            //int i = 1;
            //int j = 1;
            //int sum = i + j;
            //int count = 3;
            //while(count < 20)
            //{
            //    count++;
            //    i = j;
            //    j = sum;
            //    sum = i + j;
            //    Console.WriteLine($"第{count}位的数字是{sum}");
            //}
        }
    }
}
