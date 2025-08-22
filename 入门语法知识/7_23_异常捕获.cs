namespace test7_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.请用户输入一个数字，如果输入有错，则提示用户输入错误
            //Console.WriteLine("请输入一个数字");

            //try
            //{
            //    string str = Console.ReadLine();
            //    long i = long.Parse(str);
            //    Console.WriteLine(i);
            //}
            //catch
            //{
            //    Console.WriteLine("输入错误，请输入合法数字");
            //}

            //2.提示用户输入姓名、语文、数学、英语成绩，如果输入的成绩有误，则提示用户输入错误，否则将输入的字符串转为整型变量存储
            //try
            //{
            //    Console.WriteLine("请输入您的姓名");
            //    string str1 = Console.ReadLine();

            //    Console.WriteLine("请输入您的语文成绩");
            //    int Chinese = int.Parse(Console.ReadLine());

            //    Console.WriteLine("请输入您的数学成绩");
            //    int Math = int.Parse(Console.ReadLine());

            //    Console.WriteLine("请输入您的英语成绩");
            //    int English = int.Parse(Console.ReadLine());

            //}
            //catch
            //{
            //    Console.WriteLine("您输入的成绩有误");
            //}

            try
            {
                Console.WriteLine("请输入您的姓名：");
                string Name = Console.ReadLine();
                Console.WriteLine("请输入您的语文成绩：");
                int Chinese = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("您的语文成绩有误");
            }

            try
            {
                Console.WriteLine("请输入您的数学成绩：");
                int Math = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("您的数学成绩有误");
            }

            try
            {
                Console.WriteLine("请输入您的英语成绩：");
                int English = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("您的英语成绩有误");
            }
        }
    }
}
