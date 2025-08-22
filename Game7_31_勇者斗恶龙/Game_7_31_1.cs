namespace Test_7_31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.通过W,A,S,D键在控制台中控制一个黄色方块在红色背景中上下左右移动
            //注意：边界问题
            //知识点：while switch 输入输出等

            //改变背景颜色
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();

            //定义坐标变量
            int x = 0, y = 0;

            //设置字体颜色
            Console.ForegroundColor = ConsoleColor.Yellow;

            //光标隐藏
            Console.CursorVisible = false;

            while (true)
            {
                Console.SetCursorPosition(x, y);
                Console.Write("█");

                //接收输入的按键，隐藏输入信息
                char c = Console.ReadKey(true).KeyChar;

                //刷新原来坐标的图形
                Console.SetCursorPosition(x, y);
                Console.Write(" ");
                switch (c)
                {
                    case 'W':
                    case 'w':
                        y--;
                        if (y < 0)
                            y = 0;
                        break;
                    case 'A':
                    case 'a':
                        x -= 2;
                        if (x < 0)
                            x = 0;
                        break;
                    case 'S':
                    case 's':
                        y++;
                        if ( y > Console.BufferHeight - 1)
                            y = Console.BufferHeight - 1;
                        break;
                    case 'D':
                    case 'd':
                        x += 2;
                        if ( x > Console.BufferWidth - 2)
                            x = Console.BufferWidth - 2;
                        break;
                }
            }
        }
    }
}
