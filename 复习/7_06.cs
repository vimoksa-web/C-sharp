using System.Security.Cryptography.X509Certificates;

namespace _7_06
{
    //1.定义QQ状态的枚举，并提示玩家选择一个在线状态，我们接受输入的数字，并将其转换为枚举类型
    //enum E_QQstatus
    //{
    //    Online,
    //    Busy,
    //    Stealth,
    //    Offline,
    //}

    //2.星巴克买咖啡
    //enum E_coffeeType
    //{
    //    Middle,
    //    Big,
    //    Largest,
    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            //枚举
            //1.定义QQ状态的枚举，并提示玩家选择一个在线状态，我们接受输入的数字，并将其转换为枚举类型
            //try
            //{
            //    Console.WriteLine("请选择你的QQ在线状态(0在线，1忙碌，2隐身，3离线)");
            //    int status = int.Parse(Console.ReadLine());
            //    E_QQstatus userStatus = (E_QQstatus)status;
            //    Console.WriteLine(userStatus);
            //}catch
            //{
            //    Console.WriteLine("请输入0-3之间的数字");
            //}

            //2.用户去星巴克买咖啡，分为中杯(35元)，大杯(40元)，超大杯(43元)，
            //请用户选择要购买的类型，用户选择后，打印：您购买了XXX咖啡，花费了XX元
            //例如：你购买了中杯咖啡，花费了35元
            //try
            //{
            //    Console.WriteLine("请选择您要购买的类型(0中杯，1大杯，2超大杯)");
            //    int cafeType = int.Parse(Console.ReadLine());
            //    E_coffeeType userType = (E_coffeeType)cafeType;
            //    var (price, chineseName) = userType switch
            //    {
            //        E_coffeeType.Middle => (35, "中杯"),
            //        E_coffeeType.Big => (40, "大杯"),
            //        E_coffeeType.Largest => (43, "超大杯"),
            //        _ => throw new Exception()
            //    };
            //    Console.WriteLine($"您购买了{chineseName}咖啡，花费了{price}元");
            //}catch
            //{
            //    Console.WriteLine("请输入0-2之间的数字");
            //}


            //数组
            //1.请创建一个一维数组并赋值，让其与下标一样，长度为100
            //int[] arr1 = new int[100];
            //for(int i = 0; i<arr1.Length; i++)
            //{
            //    arr1[i] = i;
            //}
            //Console.WriteLine(string.Join(",", arr1));

            //int[] arr2 = Enumerable.Range(0, 100).ToArray();
            //Console.WriteLine(string.Join(",", arr2));

            //2.创建另一个数组B，让数组A中的每个元素的值乘以2存入到数组B中
            //int[] A = Enumerable.Range(0, 10).ToArray();
            //int[] B = new int[10];
            //for(int i = 0; i<B.Length; i++)
            //{
            //    B[i] = 2 * A[i];
            //}
            //Console.WriteLine(string.Join(",", B));

            //3.随机（0~100）生成一个长度为10的整数数组
            //Random r = new Random();
            //int[] arr1 = new int[10];
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    arr1[i] = r.Next(0, 101);
            //}
            //Console.WriteLine(string.Join(",",arr1));

            //4.从一个整数数组中找出最大值、最小值、总合、平均值（可以使用随机数1~100）
            Random r = new Random();
            int[] arr1 = new int[10];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = r.Next(0, 101);
            }

            int Max = arr1[0];
            int Min = arr1[0];
            int Sum = 0;
            int Avg = 0;
            for(int i = 0; i < arr1.Length; i++)
            {
                if(Max < arr1[i])
                    Max = arr1[i];
                if(Min > arr1[i])
                    Min = arr1[i];
                Sum += arr1[i];
            }
            Console.WriteLine(string.Join(",",arr1));
            Avg = Sum / arr1.Length;
            Console.WriteLine($"这个数组的最大值为{Max}，最小值为{Min}，总和为{Sum}，平均数为{Avg}");

        }
    }
}
