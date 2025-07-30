namespace test7_30_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.要求用户输入用户名和密码，只要不是admin和8888就一直提示用户名或密码错误，请重新输入
            //do
            //{
            //    Console.WriteLine("请输入用户名：");
            //    string str1 = Console.ReadLine();
            //    Console.WriteLine("请输入密码：");
            //    string str2 = Console.ReadLine();
            //    if (str1 != "admin" || str2 != "8888")
            //    {
            //        Console.WriteLine("用户名或密码错误，请重新输入");
            //    }
            //    else
            //    {
            //        Console.WriteLine("登陆成功");
            //        break;
            //    }
            //}while (true);

            //2.不断提示请输入你的姓名，直到输入q结束
            string Name = "";
            do
            {
                Console.WriteLine("请输入你的姓名：");
                Name = Console.ReadLine();
            } while (Name != "q");

        }
    }
}
