namespace _8.静态类和静态构造函数
{
    static class Math
    {
        public static float PI = 3.1415926f;
        public static float CircleArea(int r)
        {
            if (r < 0) return -1;
            return PI * r * r;
        }
        public static float CirclePeri(int r)
        {
            if (r < 0) return -1;
            return PI * r * 2;
        }
        public static int RectArea(int x, int y)
        {
            if (x < 0 || y < 0) return -1;
            return x * y;
        }
        public static int RectPeri(int x, int y)
        {
            if (x < 0 || y < 0) return -1;
            return (x + y) * 2;
        }
        public static int AbsoluteValue(int i)
        {
            return i >= 0 ? i : -i;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.写一个用于数学计算的静态类
            //该类中提供计算圆面积、圆周长、矩形面积、矩形周长、取一个数的绝对值等方法
            int r = 5;
            int l = 6;
            int w = 7;
            int num = -10;
            Console.WriteLine($"半径为{r}的圆的面积是{Math.CircleArea(r):F2}");
            Console.WriteLine($"半径为{r}的圆的周长是{Math.CirclePeri(r):F2}");
            Console.WriteLine($"长为{l}、宽为{w}的矩形面积为{Math.RectArea(l, w)}");
            Console.WriteLine($"长为{l}、宽为{w}的矩形周长为{Math.RectPeri(l, w)}");
            Console.WriteLine($"{num}的绝对值为{Math.AbsoluteValue(num)}");
        }
    }
}
