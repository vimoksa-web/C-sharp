namespace test7_25_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.比较两个数的大小，求出最大的
            //int a = 5;
            //int b = 10;
            //int i = a >= b ? a : b;
            //Console.WriteLine(i);

            //2.提示用户输入姓名，然后在控制台输出姓名，只要输入的不是帅哥，就显示美女
            //Console.WriteLine("请输入姓名：");
            //string strName = Console.ReadLine();
            //string str = strName == "帅哥" ? "帅哥" : "美女";
            //Console.WriteLine(str);

            //3.依次输入学生的姓名、C#的成绩、Unity的成绩，两门成绩都大于等于90才能毕业，请输出最后的结果
            //Console.WriteLine("请输入您的姓名：");
            //string Name = Console.ReadLine();
            //Console.WriteLine("请输入您的C#成绩：");
            //int scoreCsharp = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入您的姓名：");
            //int scoreUnity = int.Parse(Console.ReadLine());

            //Console.WriteLine(scoreCsharp >= 90 && scoreUnity >= 90 ? "可以毕业" : "不能毕业");

            //4.要求用户输入一个年份，然后判断是不是闰年？
            //闰年判断条件：年份能被400整除 或者 年份能被4整除，但是不能被100整除
            Console.WriteLine("请输入一个年份：");
            int Years = Convert.ToInt32(Console.ReadLine());

            string isYear = Years % 400 == 0 || (Years % 4 == 0 && Years % 100 != 0) ? "是闰年" : "不是闰年";
            Console.WriteLine(isYear);
        }
    }
}
