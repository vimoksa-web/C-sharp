namespace Test8_22_索引器
{
    //1.自定义一个整型数组类，该类中有一个整型数组变量，为它封装增删改查的方法
    class Array
    {
        public void Addarr(int value)
        {
            int[] arr2 = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = arr[i];
            }
            arr2[arr.Length - 1] = value;
            arr = arr2;
        }
        public void Delarr()
        {
            int[] arr2 = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = arr[i];
            }
        }

        private int[] arr;

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= arr.Length)
                    throw new IndexOutOfRangeException("索引超出数组范围");
                return arr[index];
            }
            set
            {
                if (index < 0 || index >= arr.Length)
                    throw new IndexOutOfRangeException("索引超出数组范围");
                arr[index] = value;
            }
        }

        public Array()
        {
            this.arr = new int[10];
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Array arr1 = new Array();

        }
    }
}
