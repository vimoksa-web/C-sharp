namespace Test8_5_2
{
    internal class Program
    {
        static bool Function1(string userName, string passWord, ref string message)
        {
            if (userName == "admin")
            {
                if (passWord == "123456")
                {
                    message = "登陆成功";
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
            //1.让用户输入用户名和密码，返回给用户一个bool类型的登陆结果，并且还要单独
            //返回给用户一个登录信息
            //如果用户名错误，除了返回登陆结果之外，登陆信息为“用户名错误”
            //如果密码错误，除了返回登陆结果之外，登陆信息为“密码错误”
            Console.WriteLine("请输入用户名");
            string userName = Console.ReadLine();
            Console.WriteLine("请输入密码");
            string passWord = Console.ReadLine();
            string message = "";

            while( !Function1(userName, passWord, ref message) )
            {
                Console.WriteLine(message);
                Console.WriteLine("请输入用户名");
                userName = Console.ReadLine();
                Console.WriteLine("请输入密码");
                passWord = Console.ReadLine();
            }
            Console.WriteLine(message);
        }
    }
}
