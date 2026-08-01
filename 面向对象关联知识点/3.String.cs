namespace _3.String
{
    internal class Program
    {
        static void ReverseString(char[] s)
        {
            if (s == null || s.Length <= 1) return;

            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                s[left] = (char)(s[left] ^ s[right]);
                s[right] = (char)(s[left] ^ s[right]);
                s[left] = (char)(s[left] ^ s[right]);

                // 两个指针向中间靠拢
                left++;
                right--;
            }
        }
        static void Main(string[] args)
        {
            #region 第一题
            //请写出 string 类型中提供的截取和替换对应的函数名。
            //截取：Substring
            //替换：Replace
            #endregion

            #region 第二题
            //请将字符串 "1|2|3|4|5|6|7" 变为 "2|3|4|5|6|7|8"
            //并输出（要求使用字符串切割的方法）。
            string str = "1|2|3|4|5|6|7";
            //删除前面
            str = str.Remove(0, 2);
            Console.WriteLine(str);
            //在后面拼接
            str = string.Format("{0}{1}", str, "|8");
            Console.WriteLine(str);
            //切割
            string[] strs = str.Split("|");
            for (int i = 0; i < strs.Length; i++)
            {
                Console.WriteLine(strs[i]);
            }

             str = "1|2|3|4|5|6|7";

            // 1. 先用切割方法 Split 拆出每个数字
            strs = str.Split('|');

            // 2. 将数组里的每个数字 +1
            for (int i = 0; i < strs.Length; i++)
            {
                int num = int.Parse(strs[i]) + 1;
                strs[i] = num.ToString();
            }

            // 3. 重新拼接并输出结果 ("2|3|4|5|6|7|8")
            string newStr = string.Join("|", strs);
            Console.WriteLine(newStr);
            #endregion

            #region 第三题
            //说明以下每组类型的区别：
            //String 与 string
            //String是命名空间名下的类名，string是关键字

            //Int32 与 int
            //Int32是.net结构体名，int是关键字

            //Int16 与 short
            //Int16是.net结构体名，short是关键字

            //Int64 与 long
            //Int64是.net结构体名，long是关键字
            #endregion

            #region 第四题
            //string str = null;
            //str = "123";//1
            //string str2 = str;
            //str2 = "321";//2
            //str2 += "123";//3
            //请问，上面这段代码执行过程中，一共分配了多少个新的堆空间？
            //3个 只要对字符串进行修改、重新赋值或拼接（+=），
            //永远不会改变原有的堆内存，而是会在堆上产生一个全新的字符串对象
            #endregion

            #region 第五题
            //编写一个函数，将输入的字符数组反转。
            //要求：不要使用中间值，必须原地修改输入数组，且交换过程中不使用额外空间。
            //例如：输入 { 'h', 'e', 'l', 'l', 'o'}，输出应为 { 'o', 'l', 'l', 'e', 'h'}。
            char[] s = { 'h', 'e', 'l', 'l', 'o' };
            ReverseString(s);
            Console.WriteLine(s);
            #endregion
        }
    }
}
