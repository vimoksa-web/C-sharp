namespace Test8_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.请创建一个一维数组并赋值，让其与下标一样，长度为100
            //int[] arr1 = new int[100];
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    arr1[i] = i;
            //    Console.WriteLine(arr1[i]);
            //}

            //2.创建另一个数组B，让数组A中的每个元素的值乘以2存入到数组B中
            //int[] A = { 1, 2, 3, 4, 5 };
            //int[] B = new int[5];
            //for (int i = 0;i < B.Length;i++)
            //{
            //    B[i] = 2 * A[i];
            //    Console.WriteLine(B[i]);
            //}

            //3.随机（0~100）生成一个长度为10的整数数组
            //Random r = new Random();
            //int[] arrRandom = new int[10];
            //for (int i = 0; i < arrRandom.Length; i++)
            //{
            //    arrRandom[i] = r.Next(0, 101);
            //    Console.WriteLine(arrRandom[i]);
            //}

            //4.从一个整数数组中找出最大值、最小值、总合、平均值（可以使用随机数1~100）
            //Random r = new Random();
            //int[] arrRandom = new int[10];
            //for (int i = 0; i < arrRandom.Length; i++)
            //{
            //    arrRandom[i] = r.Next(0, 101);
            //    Console.WriteLine(arrRandom[i]);
            //}

            //int Max = arrRandom[0];
            //int Min = arrRandom[0];
            //int Sum = 0;
            //int Avg = 0;
            //for (int i = 0; i < arrRandom.Length; i++)
            //{
            //    //最大值
            //    if (Max < arrRandom[i])
            //    {
            //        Max = arrRandom[i];
            //    }
            //    //最小值
            //    if (Min > arrRandom[i])
            //    {
            //        Min = arrRandom[i];
            //    }
            //    //总合
            //    Sum += arrRandom[i];
            //}
            ////平均值
            //Avg = Sum / arrRandom.Length;
            //Console.WriteLine("最大值为：" + Max);
            //Console.WriteLine("最小值为：" + Min);
            //Console.WriteLine("总合为：" + Sum);
            //Console.WriteLine("平均值：" + Avg);

            //5.交换数组中的第一个和最后一个、第二个和倒数第二个，以此类推，把数组进行反转并打印
            //int[] arr = { 91, 40, 57, 43, 46, 50, 41, 17, 39, 6 };

            //int num = 0;
            //int left = 0;
            //int right = arr.Length;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (left >= right)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        num = arr[i];
            //        arr[i] = arr[arr.Length - i - 1];
            //        arr[arr.Length - i - 1] = num;
            //    }
            //    left++;
            //    right--;
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //6.将一个整数数组的每一个元素进行以下的处理：
            //如果元素是正数则将这个位置的元素值加1；
            //如果元素是负数则将这个位置的元素值减1；
            //如果元素是0，则不变
            //int[] arr = { -91, 40, 57, -43, 0, -50, 41, -17, 39, -6 };

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > 0)
            //    {
            //        arr[i]++;
            //    }
            //    else if (arr[i] < 0)
            //    {
            //        arr[i]--;
            //    }
            //    Console.WriteLine(arr[i]);
            //}

            //7.定义一个有10个元素的数组，使用for循环，输入10名同学的数学成绩，将成绩依次存入数组，
            //然后分别求出最高分和最低分，并且求出10名同学的数学平均成绩
            //try
            //{
            //    int[] arr = new int[10];
            //    int Max = 0;
            //    int Min = 0;
            //    int Sum = 0;
            //    int Avg = 0;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        Console.WriteLine("请输入第{0}名学生的成绩", i + 1);
            //        arr[i] = int.Parse(Console.ReadLine());

            //        if (i == 0)
            //        {
            //            Max = arr[i];
            //            Min = arr[i];
            //        }
            //        else
            //        {
            //            if (Max < arr[i])
            //            {
            //                Max = arr[i];
            //            }
            //            if (Min > arr[i])
            //            {
            //                Min = arr[i];
            //            }
            //        }

            //        Sum += arr[i];
            //    }
            //    Avg = Sum / arr.Length;
            //    Console.WriteLine("学生们的最高分是:" + Max);
            //    Console.WriteLine("学生们的最低分是:" + Min);
            //    Console.WriteLine("学生们的平均分是:" + Avg);
            //}
            //catch
            //{
            //    Console.WriteLine("请输入数字");
            //}

            //8.请声明一个string类型的数组(长度为25)，该数组中存储着符号，
            //通过遍历数组的方式取出其中存储的符号并打印出
            string[] str = new string[25];
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = i % 2 == 0 ? "■" : "□";
            }
            for (int i = 0;i < str.Length; i++)
            {
                if (i % 5 == 0 && i != 0)
                {
                    Console.WriteLine();
                }
                Console.Write(str[i]);
            }
        }
    }
}
