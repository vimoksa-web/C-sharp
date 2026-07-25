namespace _7_25
{
    #region 成员属性
    //1.定义一个学生类，有五种属性，分别为姓名，性别，年龄，数学成绩，英语成绩
    //有两个方法：
    //一个打招呼：介绍自己叫XXX，今年几岁了，是男同学还是女同学
    //一个计算自己总分和平均分并显示的方法
    //使用属性完成，年龄必须是0~150岁之间，成绩必须是0~100
    //实例化两个对象并测试
    class Student
    {
        public string name { get; set; }
        public char sex { get; set; }
        private int age;
        private int math;
        private int english;
        public int Age
        {
            get
            {
                return age; 
            }
            set
            {
                if (value < 0 || value > 150)
                    throw new ArgumentException("年龄必须在0~150岁之间");
                age = value;
            }
        }
        public int Math 
        { 
            get
            {
                return math;
            }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException("成绩必须在0~100之间");
                math = value;
            } 
        }
        public int English
        {
            get
            {
                return english;
            }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException("成绩必须在0~100之间");
                english = value;
            }
        }
        public int Sum => this.Math + this.English;
        public float Avg => this.Sum / 2f;
        public void sayHi()
        {
            Console.WriteLine($"你好，我是{this.name}，今年{this.age}岁，性别{this.sex}");
        }
        public void Score()
        {
            Console.WriteLine($"{this.name}的总分为{this.Sum}，平均分为{this.Avg:F2}");
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 成员属性
            Student s1 = new Student();
            s1.name = "XD";
            s1.Age = 23;
            s1.sex = '男';
            s1.Math = 90;
            s1.English = 95;
            s1.sayHi();
            s1.Score();
            Console.WriteLine("----------------------------");
            Student s2 = new Student {name = "小红", Age = 24, sex = '女', Math = 80, English = 88 };
            s2.sayHi();
            s2.Score();
            #endregion
        }
    }
}
