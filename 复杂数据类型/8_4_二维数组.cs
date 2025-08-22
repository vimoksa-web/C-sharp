namespace Test8_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.将1到10000赋值给一个二维数组（100行100列）
            //int[,] arr1 = new int[100, 100];
            //int num = 1;
            //for (int i = 0; i < arr1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr1.GetLength(1); j++)
            //    {
            //        arr1[i, j] = num;
            //        Console.Write(arr1[i, j] + " ");
            //        num++;
            //    }
            //    Console.WriteLine();
            //}

            //2.将二维数组（4行4列）的右上半部分制置零（元素随机1~100）
            //Random rand = new Random();
            //int[,] arrRand = new int[4, 4];
            //for (int i = 0; i < arrRand.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arrRand.GetLength(1); j++)
            //    {
            //        if (j > 1 && i <= 1)
            //        {
            //            arrRand[i, j] = 0;
            //        }
            //        else
            //        {
            //            arrRand[i, j] = rand.Next(1, 101);
            //        }
            //        Console.Write(arrRand[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //3.求二维数组（3行3列）的对角线元素的和（元素随机1~10）
            //Random rand = new Random();
            //int[,] arrSum = new int[3, 3];
            //int Sum = 0;
            //for (int i = 0; i < arrSum.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arrSum.GetLength(1); j++)
            //    {
            //        arrSum[i, j] = rand.Next(1, 11);
            //        Console.Write(arrSum[i, j] + " ");
            //        if (i == j || i + j == arrSum.GetLength(0) - 1)
            //        {
            //            Sum += arrSum[i, j];
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("对角线元素的和是：" + Sum);

            //4.求二维数组（5行5列）中最大元素值及其行列号（元素随机1~500）
            //Random rand = new Random();
            //int[,] arrMax = new int[5, 5];
            //int Max = 0;
            //int hang = 0;
            //int lie = 0;

            //for (int i = 0; i < arrMax.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arrMax.GetLength(1); j++)
            //    {
            //        arrMax[i, j] = rand.Next(1, 501);
            //        Console.Write(arrMax[i, j] + " ");

            //        if (i == 0 && j == 0)
            //        {
            //            Max = arrMax[i, j];
            //        }
            //        else
            //        {
            //            if (Max < arrMax[i, j])
            //            {
            //                Max = arrMax[i, j];
            //                hang = i;
            //                lie = j;
            //            }
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("最大值是：" + Max);
            //Console.WriteLine("它的行列分别是{0}和{1}", hang, lie);

            //5.给一个M*N的二维数组，数组元素的值为0或者1，要求转换数组，将含有1的行和列全部置1
            int[,] arr = new int[5, 5] { { 0, 0, 0, 0, 0 },
                                              { 0, 0, 0, 0, 0 },
                                              { 0, 0, 1, 0, 0 },
                                              { 0, 0, 0, 0, 0 },
                                              { 0, 0, 0, 0, 0 }};
            bool[] hang = new bool[5];
            bool[] lie = new bool[5];

            Console.WriteLine("更改前");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == 1)
                    {
                        hang[i] = true;
                        lie[j] = true;
                    }
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("更改后");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (hang[i] || lie[j])
                    {
                        arr[i, j] = 1;
                    }
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
