namespace test7_22_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.请用户输入姓名，年龄，班级
            Console.WriteLine("请输入您的姓名");
            Console.ReadLine();

            Console.WriteLine("请输入您的年龄");
            Console.ReadLine();

            Console.WriteLine("请输入您的班级");
            Console.ReadLine();

            //2.问用户喜欢什么运动，无论用户输入什么，都回复"哈哈，好巧，我也喜欢这个运动"
            Console.WriteLine("您喜欢什么运动");
            Console.ReadLine();
            Console.WriteLine("哈哈，好巧，我也喜欢这个运动");

            //3.输入10*10的空心*矩形
            Console.WriteLine("**********");
            Console.WriteLine("*        *");
            Console.WriteLine("*        *");
            Console.WriteLine("*        *");
            Console.WriteLine("*        *");
            Console.WriteLine("*        *");
            Console.WriteLine("*        *");
            Console.WriteLine("*        *");
            Console.WriteLine("*        *");
            Console.WriteLine("**********");
        }
    }
}
