namespace _7_16
{
    #region 结构体
    //1.使用结构体描述学员的信息，姓名、性别、年龄、班级、专业，创建两个学员对象，
    //并对其基本信息进行初始化并打印
    struct Student
    {
        public string name;
        public char sex;
        public int age;
        public string banJi;
        public string zhuanYe;

        public Student(string name, char sex, int age, string banJi, string zhuanYe)
        {
            this.name = name;
            this.sex = sex;
            this.age = age;
            this.banJi = banJi;
            this.zhuanYe = zhuanYe;
        }
        public void Information()
        {
            Console.WriteLine($"姓名:{name}，性别:{sex}，年龄:{age}，班级:{banJi}，专业:{zhuanYe}");
        }
    }

    //2.使用结构体描述矩阵的信息，长、宽；创建一个矩形，对其长宽进行初始化，并打印
    //矩形的长、宽、面积、周长等信息
    struct Rectangle
    {
        public int length;
        public int width;
        public int area;
        public int girth;
        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
            area = length * width;
            girth = 2 * (length + width);
        }
        public void Information()
        {
            Console.WriteLine($"矩形长为{length}，宽为{width}，面积为{area}，周长为{girth}");
        }
    }

    //3.请使用结构体描述玩家信息，玩家名字，玩家职业
    //请用户输入玩家姓名，选择玩家职业，最后打印玩家的攻击信息职业：
    //战士（技能：冲锋）
    //猎人（技能：翻滚）
    //法师（技能：奥术冲击）
    //打印结果：猎人XXX释放了翻滚
    struct playerDetails
    {
        //声明信息
        public string playerName;
        public string playerClass;
        public string playerSkill;
        //输入玩家的信息
        public playerDetails()
        {
            try
            {
                Console.WriteLine("请输入玩家名字：");
                playerName = Console.ReadLine();
                Console.WriteLine("请输入数字选择您的职业：1.战士 2.猎人 3.法师");
                int select = int.Parse(Console.ReadLine());
                (playerClass, playerSkill) = select switch
                {
                    1 => ("战士", "冲锋"),
                    2 => ("猎人", "翻滚"),
                    3 => ("法师", "奥术冲击"),
                    _ => throw new Exception()
                };
            }catch (Exception ex)
            {
                Console.WriteLine("请输入正确的数字：1.战士 2.猎人 3.法师");
            }
        }
        //打印玩家信息
        public void playerAttack()
        {
            Console.WriteLine($"{playerClass}{playerName}释放了{playerSkill}");
        }

    }
    #endregion
    internal class Program
    {
        #region 变长参数和默认参数值
        //1.
        static void Function1(params int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                Console.WriteLine("请至少传入一个参数");
                return;
            }
            int sum = 0;
            float avg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            avg = (float)sum / arr.Length;
            Console.WriteLine($"这些数字的和为{sum}，平均值为{avg:F2}");
        }

        //2.
        static void Function2(params int[] arr)
        {
            int evenSum = 0;
            int oddSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenSum += arr[i];
                }
                else
                {
                    oddSum += arr[i];
                }
            }
            Console.WriteLine($"这些数的偶数和为{evenSum}，奇数和为{oddSum}");
        }
        #endregion

        #region 函数重载
        //1.
        static int Bigger(int x, int y)
        {
            return x > y ? x : y;
        }
        static float Bigger(float x, float y)
        {
            return x > y ? x : y;
        }
        static double Bigger(double x, double y)
        {
            return x > y ? x : y;
        }

        //2.
        static int Max(params int[] arr)
        {
            if(arr == null || arr.Length == 0)
            {
                Console.WriteLine("请至少传入一个参数");
                return -1;
            }
            int max = arr[0];
            for (int i = 1;i < arr.Length;i++)
            {
                if( arr[i] > max )
                    max = arr[i];
            }
            return max;
        }
        static float Max(params float[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                Console.WriteLine("请至少传入一个参数");
                return -1;
            }
            float max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }
        static double Max(params double[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                Console.WriteLine("请至少传入一个参数");
                return -1;
            }
            double max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }
        #endregion

        #region 递归函数
        //1.
        static void Add(int x)
        {
            if (x > 10)
                return;
            Console.Write(x + " ");
            x++;
            Add(x);
        }

        //2.
        static int Factorial(int x)
        {
            if (x == 1)
                return 1;
            return x * Factorial(x - 1);
        }
        static int Fun(int x)
        {
            if (x == 1)
                return 1;
            return Factorial(x) + Fun(x - 1);
        }
        #endregion

        static void Main(string[] args)
        {
            #region 变长参数和参数默认值
            //1.使用params参数，求多个数字的和以及平均值
            //Random r = new Random();
            //int[] arr1 = new int[10];
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    arr1[i] = r.Next(0, 11);
            //}
            //Console.WriteLine(string.Join(",", arr1));
            //Function1(arr1);

            //2.使用params参数，求多个数字的偶数和奇数和
            //Function2(1,2,3,4,5,6,7,8,9);
            #endregion

            #region 函数重载
            //1.请重载一个函数，让其可以比较两个int或两个float或两个double的大小，并返回较大的那个值
            //Console.WriteLine(Bigger(15, 20));
            //Console.WriteLine(Bigger(7.6f, 8.1f));
            //Console.WriteLine(Bigger(0.8, 0.19));

            //2.请重载一个函数，让其可以比较n个int或n个float或n个double的大小，
            //并返回较大的那个值（用params可变参数来完成）
            //Console.WriteLine(Max(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
            //Console.WriteLine(Max(4.5f, 8.9f, 6.6f, 3.4f, 7.7f));
            //Console.WriteLine(Max(3.8, 1.4, 8.8, 6.5, 3.3, 9.8));
            #endregion

            #region 递归函数
            //1.使用递归的方式打印0~10
            //Add(0);

            //2.传入一个值，递归求该值的阶乘，并返回
            //5! = 1*2*3*4*5
            //int i = 10;
            //Console.WriteLine($"{i}的阶乘为{Factorial(i)}");

            //3.使用递归求1! + 2! + 3! + 4! + ...... + 10!
            //Console.WriteLine($"1! + 2! + 3! + 4! + ...... + 10!={Fun(10)}");
            #endregion

            #region 结构体
            //1.
            //Student s1 = new Student("XD", '男', 23, "二班", "软件工程");
            //Student s2 = new Student("张三", '女', 19, "一班", "计算机科学");
            //s1.Information();
            //s2.Information();

            //2.
            //Rectangle r1 = new Rectangle(5, 7);
            //r1.Information();

            //3.
            //playerDetails p1 = new playerDetails();
            //p1.playerAttack();
            #endregion
        }
    }
}
