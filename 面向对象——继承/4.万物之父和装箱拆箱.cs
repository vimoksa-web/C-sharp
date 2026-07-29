namespace _4.万物之父和装箱拆箱
{
    //1.请口头描述什么是装箱和拆箱
    //装箱：用object类存储值类型
    //拆箱：把存储的object类转换为值类型

    
    internal class Program
    {
        //2.请用代码描述装箱拆箱
        //拆箱
        static int[] Unboxing(object[] o)
        {
            if (o == null || o.Length == 0)
                return null;
            int[] arr = new int[o.Length];
            for (int i = 0; i < o.Length; i++)
            {
                arr[i] = (int)o[i];
            }
            return arr;
        }
        static void Main(string[] args)
        {
            //装箱
            Random r = new Random();
            object[] o = new object[10];
            for (int i = 0; i < o.Length; ++i)
            {
                o[i] = r.Next(0, 11);
            }
            Console.WriteLine(string.Join(",", Unboxing(o)));
        }
    }
}
