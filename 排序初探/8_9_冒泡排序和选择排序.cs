namespace Test8_9
{
    internal class Program
    {

        //2.写一个函数，实现一个数组的排序，并返回结果，可以根据参数决定是升序还是降序
        //static int[] Sort(bool isOrder, int[] arr)
        //{
        //    bool isSort = false;
        //    if (isOrder)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            for (int j = 0; j < arr.Length - 1 - i; j++)
        //            {
        //                isSort = false;
        //                if (arr[j] > arr[j + 1])
        //                {
        //                    isSort = true;
        //                    int temp = arr[j];
        //                    arr[j] = arr[j + 1];
        //                    arr[j + 1] = temp;
        //                }
        //            }
        //            if (!isSort)
        //            {
        //                break;
        //            }
        //        }
        //        return arr;
        //    }
        //    else
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            for (int j = 0; j < arr.Length - 1 - i; j++)
        //            {
        //                isSort = false;
        //                if (arr[j] < arr[j + 1])
        //                {
        //                    isSort = true;
        //                    int temp = arr[j];
        //                    arr[j] = arr[j + 1];
        //                    arr[j + 1] = temp;
        //                }
        //            }
        //            if (!isSort)
        //            {
        //                break;
        //            }
        //        }
        //        return arr;
        //    }
        //}

        //优化后
        static int[] Sort(bool isOrder, int[] arr)
        {
            bool isAscendOrder;
            bool isSort = false;
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                isSort = false;
                for (int j = 0; j < arr.Length - 1 - j; j++)
                {
                    isAscendOrder = isOrder ? arr[j] > arr[j + 1] : arr[j] < arr[j + 1];
                    if (isAscendOrder)
                    {
                        isSort = true;
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
                if (isSort)
                {
                    break;
                }
            }
            return arr;
        }
        static void Main(string[] args)
        {
            //1.定义一个数组，长度为20，每个元素值随机0~100的数
            //使用冒泡排序进行升序排序并打印
            //使用冒泡排序进行降序排序并打印
            int[] arr1 = new int[20];
            Random rand = new Random();
            //升序
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = rand.Next(0, 101);
                Console.Write(arr1[i] + " ");
            }
            Console.WriteLine();
            bool isSort = false;
            for (int i = 0; i < arr1.Length; i++)
            {
                isSort = false;
                for (int j = 0; j < arr1.Length - 1 - i; j++)
                {
                    isSort = true;
                    if (arr1[j] > arr1[j + 1])
                    {
                        isSort = true;
                        int temp = arr1[j];
                        arr1[j] = arr1[j + 1];
                        arr1[j + 1] = temp;
                    }
                }
                if ( !isSort )
                {
                    break;
                }
            }
            for (int i = 0;i < arr1.Length;i++)
            {
                Console.Write(arr1[i] + " ");
            }
            Console.WriteLine();

            //降序
            for (int i = 0; i <= arr1.Length; i++)
            {
                isSort = false;
                for (int j = 0; j < arr1.Length - 1 - i; j++)
                {
                    if (arr1[j]  < arr1[j + 1])
                    {
                        isSort = true;
                        int temp = arr1[j];
                        arr1[j] = arr1[j + 1];
                        arr1[j + 1] = temp;
                    }
                }
                if (!isSort)
                {
                    break;
                }
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------------");

            //2.
            try
            {
                Console.WriteLine("请选择对数组升序排列(true)还是降序排列(false)");
                bool order = bool.Parse(Console.ReadLine());

                for (int i = 0; i < arr1.Length; i++)
                {
                    Console.Write(Sort(order, arr1)[i] + " ");
                }
            }
            catch
            {
                Console.WriteLine("请输入true或false");
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------------");

            //3.定义一个数组，长度为20，每个元素值随机0~100的数
            //使用选择排序进行升序排序并打印
            //使用选择排序进行降序排序并打印
            int[] arr2 = new int[20];
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = rand.Next(0, 101);
                Console.Write(arr2[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            int index = 0;
            int temp1 = 0;
            //升序
            for (int i = 0;i < arr2.Length; i++)
            {
                index = 0;
                for (int j = 1; j < arr2.Length - i; j++)
                {
                    if (arr2[index] < arr2[j])
                    {
                        index = j;
                    }
                }
                if (index != arr2.Length - 1 - i)
                {
                    temp1 = arr2[index];
                    arr2[index] = arr2[arr2.Length - 1 - i];
                    arr2[arr2.Length - 1 - i] = temp1;
                }
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------------");

            //降序
            for (int i = 0; i < arr2.Length; i++)
            {
                index = 0;
                for (int j = 1; j < arr2.Length - i; j++)
                {
                    if (arr2[index] > arr2[j])
                    {
                        index = j;
                    }
                }
                if (index != arr2.Length - 1 - i)
                {
                    temp1 = arr2[index];
                    arr2[index] = arr2[arr2.Length - 1 - i];
                    arr2[arr2.Length - 1 - i] = temp1;
                }
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }
        }
    }
}
