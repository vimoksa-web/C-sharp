namespace test7_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.33 << 4 和 66 >> 1 的结果为
            int a = 33; //100001 << 4 = 1000010000 = 16 + 512 = 528
            int b = 66; //1000010 >> 1 = 100001 = 1 + 32 = 33
            Console.WriteLine(a << 4);
            Console.WriteLine(b >> 1);

            //2.99 ^ 33 和 76 | 85的结果为
            a = 99; 
            //99 = 1100011
            //33 = 0100001
            //     1000010 = 66
            b = 76; 
            //76 = 1001100
            //85 = 1010101
            //     1011101 = 93
            Console.WriteLine(a ^ 33);
            Console.WriteLine(b | 85);
        }
    }
}
