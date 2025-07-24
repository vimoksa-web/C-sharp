namespace test7_23_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.定义一个变量储存你的年龄，十年后你的年龄是多少，请输出到控制台
            //Console.WriteLine("请输入您的年龄：");
            //int Age = int.Parse(Console.ReadLine());
            //Age = Age + 10;
            //Console.WriteLine("十年后您的年龄为：" + Age);

            //2.计算一个半径为5的圆的面积和周长
            //float r = 5;
            //float PI = 3.14f;
            //float Area = PI * r * r;
            //float Girth = 2 * PI * r;
            //Console.WriteLine("面积为：" + Area);
            //Console.WriteLine("周长为：" + Girth);

            //3.计算三门成绩的总分、平均分并打印到控制台，三门成绩均为整数类型
            //Console.WriteLine("请输入您的语文成绩：");
            //int Chinese = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入您的数学成绩：");
            //int Math = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入您的英语成绩：");
            //int English = int.Parse(Console.ReadLine());

            //int sum = Chinese + Math + English;
            //float avg = score / 3f;
            //Console.WriteLine("您的总分为：" + sum);
            //Console.WriteLine("您的平均分为：" + avg);

            //4.商店T恤的价格为285元/件，裤子的价格为720元/条，小李在该店买了2件T恤和3条裤子，
            //请计算小李该付多少钱，打3.8折后呢？
            //int Cost = 2 * 285 + 3 * 720;
            //Console.WriteLine("小李要付" + Cost + "元");
            //float Discount = 0.38f * Cost;
            //Console.WriteLine("打3.8折后要付" + Discount + "元");

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
            //int a = 99, b = 87;
            //int c = a;
            //a = b;
            //b = c;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //a = 99;
            //b = 87;
            //a = a + b;// a = 99 + 87
            //b = a - b;// b = 99 + 87 -87 = 99
            //a = a - b;// a = 99 + 87 -99 = 87
            //Console.WriteLine(a);
            //Console.WriteLine(b);


            //7.请把987652秒通过代码转换为n天n时n分n秒显示在控制台中
            int Time = 987652;
            int oneDays = 24 * 60 * 60;//一天对应的秒数
            int oneHours = 60 * 60;//一小时对应的秒数
            int oneMinutes = 60;//一分钟的秒数

            int Day = Time / oneDays;
            int Hour = (Time % oneDays) / oneHours;//用不足一天的秒数 / 一小时对应的秒数
            int Minute = (Time % oneHours) / oneMinutes;//不足一小时的秒数 / 一分钟对应的秒数
            int Second = Time % 60;

            Console.WriteLine(Day + "天" + Hour + "时" + Minute + "分" + Second + "秒");
        }
    }
}
