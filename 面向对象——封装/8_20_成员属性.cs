namespace Test8_20_成员属性
{
    //1.定义一个学生类，有五种属性：姓名、性别、年龄、Csharp成绩、Unity成绩
    //有两个方法：
    //打招呼：介绍自己叫XX，年龄、性别
    //计算成绩：计算自己总分数和平均分并显示
    //使用成员属性完成：年龄必须是0~150岁之间，成绩必须是0~100，性别只能是男或女
    //实例化两个对象并测试

    class Student
    {
        public void Introduce()
        {
            Console.WriteLine("你好，我是{0}，今年{1}岁，性别{2}", name, age, sex ? "男" : "女");
        }
        public void Score()
        {
            float avg = (csharp + unity) / 2;
            Console.WriteLine("你的总分为{0}，平均分为{1}", csharp + unity, avg);
        }

        public string name;
        public bool sex;
        private int age;
        private int csharp;
        private int unity;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                    value = 0;
                else if (value > 150)
                    value = 150;
                age = value;
            }
        }

        public int Csharp
        {
            get
            {
                return csharp;
            }
            set
            {
                if (value < 0)
                    value = 0;
                else if (value > 100)
                    value = 100;
                csharp = value;
            }
        }
        public int Unity
        {
            get
            {
                return unity;
            }
            set
            {
                if (value < 0)
                    value = 0;
                else if (value > 100)
                    value = 100;
                unity = value;
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.name = "张三";
            s1.sex = true;
            s1.Age = 25;
            s1.Csharp = 88;
            s1.Unity = 95;
            s1.Introduce();
            s1.Score();

            Console.WriteLine("----------------------------------");

            Student s2 = new Student();
            s2.name = "李四";
            s2.sex = false;
            s2.Age = 20;
            s2.Csharp = 98;
            s2.Unity = 100;
            s2.Introduce();
            s2.Score();

        }
    }
}
