namespace Test7_30_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.输出1~100之间的整数(含100)
            //for (int i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //2.求1~100之间所有偶数的和
            //int sum = 0;
            //for (int i = 0; i < 100; i += 2)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);

            //3.找出100~999之间的水仙花数
            //例如：153 = 1*1*1 + 5*5*5 + 3*3*3，这个数就是水仙花数
            //for (int i = 100; i < 999; i++)
            //{
            //    int n1 = i / 100;
            //    int n2 = (i % 100) / 10;
            //    int n3 = i % 10;
            //    if (i == n1*n1*n1 + n2*n2*n2 + n3*n3)
            //    {
            //        Console.WriteLine("{0}是水仙花数", i);
            //    }

            //}

            //4.在控制台输出九九乘法表
            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("{0} * {1} = {2} ", j, i, i * j);
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("{0} * {1} = {2}  ", j, i, i * j);
            //    }
            //    Console.WriteLine();
            //}

            //5.在控制台上输出10*10的空心星型方阵
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i == 1 || i == 10)
            //    {
            //        Console.WriteLine("**********");
            //    }
            //    else
            //    {
            //        Console.WriteLine("*        *");
            //    }
            //}

            //两层循环外层可以看作 行
            //       内层可以看作 列
            //for (int i = 0; i < 10; i++)
            //{
            //    for(int j = 0; j < 10; j++)
            //    {
            //        if (i == 0 || i == 9)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            if (j == 0 || j == 9)
            //            {
            //                Console.Write("*");
            //            }
            //            else
            //            {
            //                Console.Write(" ");
            //            }
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //6.在控制台上输出10*10的三角形方阵
            //for (int i = 0; i <= 10; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //7.在控制台上输出10行的等腰三角形方阵
            //行
            for (int i = 1; i <= 10; i++)
            {
                //打印空格的列
                for (int j = 0; j < 10 - i; j++)
                {
                    Console.Write(" ");
                }

                //打印星号的列
                for (int k = 0; k < 2*i - 1; k++)
                { 
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
