namespace Test8_5
{
    internal class Program
    {
        //1.
        static int Function1(int x, int y)
        {
            //1.
            if (x > y)
            {
                return x;
            }
            else
            {
                return y;
            }

            //2.
            //return a > b ? a : b;
        }

        //2.
        static int[] Function2(int r)
        {
            float pai = 3.1415f;
            int area = Convert.ToInt32(2 * r * pai);
            int girth = Convert.ToInt32(pai * r * r);
            return new int[] { area, girth };
        }

        //3.
        static int[] Function3(int[] arr)
        {
            int sum = 0;
            int max = arr[0];
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if (max < arr[i])
                {
                    max = arr[i];
                }
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            int avg = sum / arr.Length;
            return new int[] { sum, max, min, avg };
        }

        //4.第一种
        //static void Function4(int x)
        //{
        //    int i = 2;
        //    while (x > i)
        //    {
        //        if (x % i == 0)
        //        {
        //            break;
        //        }
        //        ++i;
        //    }
        //    if (x != i)
        //    {
        //        Console.WriteLine(x + "不是素数");
        //    }
        //    else
        //    {
        //        Console.WriteLine(x + "是素数");
        //    }

        //}
        //第二种
        static bool Function4(int x)
        {
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        //5.
        static void Function5(int x)
        {
            if (x % 400 ==0 || x % 4 == 0 && x % 100 != 0)
            {
                Console.WriteLine("是闰年");
            }
            else
            {
                Console.WriteLine("不是闰年");
            }
        }
        static void Main(string[] args)
        {
            //1.写一个函数，比较两个数字的大小，返回最大值
            Console.WriteLine(Function1(15, 20));

            //2.写一个函数，用于计算一个圆的面积和周长，并返回打印
            int[] arr1 = Function2(5);
            Console.WriteLine("圆的面积是：{0}  圆的周长是：{1}", arr1[0], arr1[1]);

            //3.写一个函数，求一个数组的总合、最大值、最小值、平均值
            int[] arrMath = { 10, 18, 23, 42, 8, 0, 56};
            int[] arr2 = Function3(arrMath);
            Console.WriteLine("总合为：{0}, 最大值为：{1}, 最小值为：{2}, 平均值为：{3}", arr2[0], arr2[1], arr2[2], arr2[3]);

            //4.写一个函数，判断你传入的参数是不是质数
            //质数：只能被1和它自身整除的数
            Function4(10);
            Console.WriteLine("{0}{1}质数", 10, Function4(10) ? "是" : "不是");

            //5.写一个函数，判断你输入的年份是否是闰年
            //闰年判断条件：年份能被400整除(2000) 或者 年份能被4整除，但是不能被100整除
            Function5(2040);
        }
    }
}
