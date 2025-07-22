namespace test7_22_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1.请将24069转成字符并打印
            char c = (char)24069;
            Console.WriteLine(c);

            c = Convert.ToChar(24069);
            Console.WriteLine(c);


            //2.提示用户输入姓名、语文、数学、英语成绩，并将输入的成绩用整型变量储存
            Console.WriteLine("请输入您的姓名");
            string Name = Console.ReadLine();

            Console.WriteLine("请输入您的语文成绩");
            string Chinese = Console.ReadLine();
            int Chinese1 = Convert.ToInt32(Chinese);
            Console.WriteLine(Name + "的语文成绩为：" + Chinese1);

            Console.WriteLine("请输入您的数学成绩");
            string Math = Console.ReadLine();
            int Math1 = Convert.ToInt32(Math);
            Console.WriteLine(Name + "的数学成绩为：" + Math1);

            Console.WriteLine("请输入您的英语成绩");
            string English = Console.ReadLine();
            int English1 = Convert.ToInt32(English);
            Console.WriteLine(Name + "的英语成绩为：" + English1);
        }
    }
}
