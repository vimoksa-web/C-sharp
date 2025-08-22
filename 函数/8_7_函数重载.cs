namespace Test8_7
{
    internal class Program
    {

        //1.int类型
        static int Function1(int x, int y)
        { 
            return x > y ? x : y;
        }
        //float类型
        static float Function1(float x, float y)
        {
            return x > y ? x : y;
        }
        //double类型
        static double Function1(double x, double y)
        {
            return x > y ? x : y;
        }


        //2.int类型
        static int Function2(params int[] arr)
        {
            if (arr.Length == 0)
                return -1;
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }
        //float类型
        static float Function2(params float[] arr)
        {
            if (arr.Length == 0)
                return -1;
            float max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }
        //double类型
        static double Function2(params double[] arr)
        {
            if (arr.Length == 0)
                return -1;
            double max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            //1.请重载一个函数，让其可以比较两个int或两个float或两个double的大小，并返回较大的那个值
            Console.WriteLine(Function1(6, 8));
            Console.WriteLine(Function1(3.8f, 9.9f));
            Console.WriteLine(Function1(9.8, 10.1));

            //2.请重载一个函数，让其可以比较n个int或n个float或n个double的大小，并返回较大的那个值（用params可变参数来完成）
            int[] arrInt = { 8, 10, 3, 9, 1 };
            float[] arrFloat = { 1.1f, 2.3f, 3.9f, 0.8f, 9.1f };
            double[] arrDouble = { 9.8, 10.2, 14.5, 5.6, 7.7 };

            Console.WriteLine(Function2(arrInt));
            Console.WriteLine(Function2(arrFloat));
            Console.WriteLine(Function2(arrDouble));
        }
    }
}
