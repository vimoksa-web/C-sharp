namespace _7_25_索引器
{
    #region 索引器
    //1.自定义一个整型数组类，该类中有一个整型数组变量，
    //为它封装增删改查的方法
    class Number
    {
        public int[] array;
        public int this[int index]
        {
            get
            {
                if (array == null || array.Length - 1 < index || index < 0)
                    return 0;
                return array[index];
            }
            set
            {
                if (array == null || array.Length - 1 < index || index < 0)
                    throw new IndexOutOfRangeException("索引越界");
                array[index] = value;
            }
        }
        public void Add(int x)
        {
            if (array == null)
            {
                array = new int[] { x };
                return;
            }
            int[] addArr = new int [array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                addArr [i] = array [i];
            }
            addArr [addArr.Length - 1] = x;
            this.array = addArr;
        }
        public void Del(int index)
        {
            if (array == null || array.Length - 1 < 0 || index < 0 || index >= array.Length)
                return;
            int[] delArr = new int[array.Length - 1];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i == index)
                    continue;
                delArr[j] = array [i];
                j++;
            }
            this.array = delArr;
        }
        public void Edit(int index, int x)
        {
            if (array == null || array.Length - 1 < 0 || index < 0 || index >= array.Length)
                return;
            array[index] = x;
        }
        public void Search(int x)
        {
            if (array == null || array.Length - 1 < 0)
                return;
            for (int i =0; i < array.Length; i++)
            {
                if (array[i] == x)
                { 
                    Console.WriteLine($"{x}所在的下标为{i}");
                    return;
                }
            }
            Console.WriteLine("没找到该元素");
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 索引器
            //1.
            Number n1 = new Number();
            n1.Add(0);
            n1.Add(1);
            n1.Add(2);
            n1.Add(3);
            n1.Add(4);
            n1.Add(5);
            n1.Add(6);
            n1.Add(7);
            n1.Add(8);
            n1.Add(9);
            Console.WriteLine(string.Join(",", n1.array));
            n1.Del(0);
            Console.WriteLine(string.Join(",", n1.array));
            n1.Edit(0, 10);
            Console.WriteLine(string.Join(",", n1.array));
            n1.Search(1);
            #endregion
        }
    }
}
