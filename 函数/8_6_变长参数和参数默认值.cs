namespace Test8_6
{
    internal class Program
    {
        //1.
        static int[] Function1(params int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            int avg = sum / arr.Length;
            return new int[] {sum, avg};
        }

        //2.
        static int[] Function2(params int[] arr)
        {
            int sumJiShu = 0;
            int sumOuShu = 0;
            for(int i = 0;i < arr.Length;i++)
            {
                if (arr[i] % 2 == 0)
                    sumOuShu += arr[i];
                else
                    sumJiShu += arr[i];
            }
            return new int[] {sumJiShu, sumOuShu};
        }
        static void Main(string[] args)
        {
            //1.使用params参数，求多个数字的和以及平均值
            Random rand = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 101);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            int[] arr2 = Function1(arr);
            Console.WriteLine("这些数字的和为{0}，平均值为{1}", arr2[0], arr2[1]);

            //2.使用params参数，求多个数字的偶数和奇数和
            int[] arr3 = Function2(arr);
            Console.WriteLine("这些数字的奇数和为{0}，偶数和为{1}", arr3[0], arr3[1]);
        }
    }
}
