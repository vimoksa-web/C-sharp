namespace Test8_7_2
{
    internal class Program
    {
        //1.
        static void Fun(int a)
        {
            if (a > 10)
                return;
            Console.Write(a + " ");
            a++;
            Fun(a);
        }

        //2.
        static int Factorial(int num)
        {
            if (num == 1)
                return 1;
            return num * Factorial(num - 1);
        }

        //3.
        static void Sum(int x,  int sum)
        {
            if (x > 10)
                return;
            int mul = 1;
            for (int i = 1; i <= x; i++)
            {
                mul *= i ;
            }
            sum += mul;
            if (x == 10)
                Console.WriteLine("1! + 2! + 3! + 4! + ...... + 10! = " + sum);
            x++;
            Sum(x, sum);
        }

        static int Function(int sum)
        {
            if (sum == 1)
            {
                return Factorial(1);
            }
            return Factorial(sum) + Function(sum - 1);
        }

        //4.
        static void Long(float x, int day)
        {
            x /= 2f;
            if (day == 10)
            {
                Console.WriteLine("第{0}天竹竿的长度为{1}", day, x);
                return;
            }
            day++;
            Long(x, day);
        }

        //5.
        static bool Print(int x)
        {
            Console.WriteLine(x);
            return x == 200 || Print(x + 1);
        }
        static void Main(string[] args)
        {
            //1.使用递归的方式打印0~10
            Fun(0);
            Console.WriteLine();

            //2.传入一个值，递归求该值的阶乘，并返回
            //5! = 1*2*3*4*5
            int i = 10;
            Console.WriteLine(i + "的阶乘为：" + Factorial(i));

            //3.使用递归求1! + 2! + 3! + 4! + ...... + 10!
            Sum(1, 0);
            Console.WriteLine("1! + 2! + 3! + 4! + ...... + 10! = " + Function(10));

            //4.一根竹竿长100m，每天砍掉一半，求第十天它的长度是多少（从第0天开始）
            Long(100f, 0);

            //5.不允许使用循环语句、条件语句，在控制台中打印出1~200这200个数（提示：递归 + 短路）
            Print(1);
        }
    }
}
