using System.Runtime.Intrinsics.X86;

namespace _7_08
{
    internal class Program
    {
        //1
        static int Max(int x, int y)
        {
            if (x > y)
                return x;
            else
                return y;
        }
        //2
        static void Circle(int r)
        {
            float area = 3.14f * r * r;
            float perimeter = 3.14f * r * 2;
            Console.WriteLine($"半径为{r}的圆，面积为{area}，周长为{perimeter}");
        }
        //3
        static void Function(int[] arr)
        {
            int sum = 0;
            float avg = 0;
            int max = arr[0];
            int min = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                    max = arr[i];
                if (min > arr[i])
                    min = arr[i];
                sum += arr[i];
            }
            avg = (float)sum / arr.Length;
            Console.WriteLine($"这个数组总和为{sum},平均值为{avg:F2},最大值为{max},最小值为{min}");
        }
        //4
        static void primeNumber(int x)
        {
            for(int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    Console.WriteLine("不是质数");
                    return;
                }
            }
            Console.WriteLine("是质数");
        }
        //5
        static void leapYear(int x)
        {
            if (x % 400 == 0 || x % 4 == 0 && x % 100 != 0)
                Console.WriteLine("是闰年");
            else
                Console.WriteLine("不是闰年");
        }

        //1
        static bool Admin(string username, string password, ref string message)
        {
            if (username == "admin")
            {
                if (password == "123456")
                {
                    message = "登录成功";
                }
                else
                {
                    message = "密码错误";
                    return false;
                }
            }
            else
            {
                message = "用户名错误";
                return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            #region 二维数组
            //1.将1到10000赋值给一个二维数组（100行100列）
            //int[,] arr1 = new int[100,100];
            //int num = 1;
            //for(int i  = 0; i < arr1.GetLength(0); i++)
            //{
            //    for(int j = 0; j < arr1.GetLength(1); j++)
            //    {
            //        arr1[i, j] = num;
            //        num++;
            //    }
            //}

            //for (int i = 0; i < arr1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr1.GetLength(1); j++)
            //    {
            //        Console.Write(arr1[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //2.将二维数组（4行4列）的右上半部分制置零（元素随机1~100）
            //生成二维数组
            //int[,] arr1 = new int[4, 4];
            //Random r = new Random();
            //for(int i = 0; i < arr1.GetLength(0); i++)
            //{
            //    for(int j = 0; j < arr1.GetLength(1); j++)
            //    {
            //        arr1[i, j] = r.Next(1, 101);
            //    }
            //}
            ////置零
            //for(int i = 0; i < arr1.GetLength(0); i++)
            //{
            //    for(int j = i+1; j < arr1.GetLength(1); j++)
            //    {
            //        arr1[i, j] = 0;
            //    }
            //}
            ////打印
            //for (int i = 0; i < arr1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr1.GetLength(1); j++)
            //    {
            //        Console.Write(arr1[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //3.求二维数组（3行3列）的对角线元素的和（元素随机1~10）
            //int[,] arrSum = new int[3, 3];
            //Random r = new Random();
            //int sum = 0;
            //for(int i = 0; i < arrSum.GetLength(0); i++)
            //{
            //    for(int j = 0; j < arrSum.GetLength(1); j++)
            //    {
            //        arrSum[i, j] = r.Next(1, 11);
            //    }
            //}

            //for(int i = 0; i < arrSum.GetLength(0); i++)
            //{
            //    sum += arrSum[i, i];
            //}
            //Console.WriteLine(sum);

            //4.求二维数组（5行5列）中最大元素值及其行列号（元素随机1~500）
            //int[,] arrMax = new int[5, 5];
            //Random r = new Random();
            //int max = 0;
            //int hang = 0;
            //int lie = 0;
            //for(int i = 0; i < arrMax.GetLength(0); i++)
            //{
            //    for(int j = 0; j < arrMax.GetLength(1); j++)
            //    {
            //        arrMax[i, j] = r.Next(1, 501);
            //        if(max < arrMax[i,j])
            //        {
            //            max = arrMax[i,j];
            //            hang = i;
            //            lie = j;
            //        }
            //    }
            //}
            //for(int i = 0; i < arrMax.GetLength(0); i++ )
            //{
            //    for( int j = 0;j < arrMax.GetLength(1);j++)
            //    {
            //        Console.Write(arrMax[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine($"最大值为{max},他在第{hang+1}行第{lie+1}列");

            //5.给一个M*N的二维数组，数组元素的值为0或者1，要求转换数组，将含有1的行和列全部置1
            //int[,] arr = new int[5, 5] { { 0, 0, 0, 0, 0 },
            //                             { 0, 1, 0, 0, 0 },
            //                             { 0, 0, 1, 0, 0 },
            //                             { 0, 0, 0, 0, 0 },
            //                             { 0, 0, 0, 0, 0 } };
            //bool[] hang = new bool[5];
            //bool[] lie = new bool[5];
            //Console.WriteLine("更改前");
            //for(int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for(int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        if (arr[i,j] == 1)
            //        {
            //            hang[i] = true;
            //            lie[j] = true;
            //        }
            //        Console.Write(arr[i,j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("更改后");
            //for(int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for(int j = 0;j < arr.GetLength(1); j++)
            //    {
            //        if (hang[i] || lie[j])
            //            arr[i, j] = 1;
            //        Console.Write(arr[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 函数
            //1.写一个函数，比较两个数字的大小，返回最大值
            //Console.WriteLine(Max(10,20));

            //2.写一个函数，用于计算一个圆的面积和周长，并返回打印
            //Circle(3);

            //3.写一个函数，求一个数组的总合、最大值、最小值、平均值
            //Random r = new Random();
            //int[] arr = new int[10];
            //for(int i =0; i<arr.Length; i++)
            //{
            //    arr[i] = r.Next(1,100);
            //}
            //Console.WriteLine(string.Join(",",arr));
            //Function(arr);

            //4.写一个函数，判断你传入的参数是不是质数
            //质数：只能被1和它自身整除的数
            //primeNumber(7);

            //5.写一个函数，判断你输入的年份是否是闰年
            //闰年判断条件：年份能被400整除(2000) 或者 年份能被4整除，但是不能被100整除
            leapYear(2040);
            #endregion

            #region ref和out
            //1.让用户输入用户名和密码，返回给用户一个bool类型的登陆结果，并且还要单独
            //返回给用户一个登录信息
            //如果用户名错误，除了返回登陆结果之外，登陆信息为“用户名错误”
            //如果密码错误，除了返回登陆结果之外，登陆信息为“密码错误”
            Console.WriteLine("请输入用户名");
            string userName = Console.ReadLine();
            Console.WriteLine("请输入密码");
            string passWord = Console.ReadLine();
            string message = "";

            while( !Admin(userName,passWord,ref message))
            {
                Console.WriteLine(message);
                Console.WriteLine("请输入用户名");
                userName = Console.ReadLine();
                Console.WriteLine("请输入密码");
                passWord = Console.ReadLine();
            }
            Console.WriteLine(message);
            #endregion

        }
    }
}
