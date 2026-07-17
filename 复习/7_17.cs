using System.Runtime.Intrinsics.Arm;
using System.Runtime.Serialization;

namespace _7_17
{
    #region 类和对象
    class GameObject
    {

    }
    #endregion

    #region 成员变量和访问修饰符
    ////2.
    //enum E_sex
    //{
    //    男,
    //    女,
    //}
    //class Person
    //{
    //    string name;
    //    E_sex sex;
    //    public int age;
    //    int height;
    //    string position;
    //}

    ////3.
    //class Student
    //{
    //    string name;
    //    int Sno;
    //    public int age;
    //    public Student Deskmate;
    //    public void StuFun()
    //    {

    //    }
    //}

    ////4.
    //class Classroom
    //{
    //    string majorName;
    //    int classVolume;
    //    Student[] student;
    //}
    #endregion

    #region 成员方法
    //1.
    class Person
    {
        public string name;
        public float height;
        public int age;
        public string position;
        public int calories = 1000;
        public void Speak(Food food)
        {
            if (food.name != null)
                Console.WriteLine($"{this.name}今天吃的{food.name}");
            else
                Console.WriteLine($"{this.name}今天还没有吃");
        }
        public void Walk()
        {
            this.calories -= 300;
            Console.WriteLine($"{this.name}走路消耗了300热量");
        }
        public void Eat(Food food)
        {
            this.calories += food.calories;
            Console.WriteLine($"{this.name}吃了{food.name}，增加了{food.calories}热量");
        }
    }
    //2.
    class Student
    {
        public string name;
        public int sno;
        public int age;
        public Student deskmate;
        public int calories;
        public void Study()
        {

        }
        public void Eat()
        {
            
        }
    }
    //3.
    class Food
    {
        public string name;
        public int calories;
        public Food(string name, int calories)
        {
            if (calories < 0)
                throw new ArgumentException("食物热量不能小于0");
            this.name = name;
            this.calories = calories;
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 类和对象
            //1.
            //GameObject A = new GameObject();//A在堆中分配了一个空间，在栈中存放了指针变量指向堆
            //GameObject B = A;//，把A的地址赋给B，让B的栈指向A所在的堆
            //B = null;//B的指针为空，不影响堆
            //此时A=？
            //所以A=一开始的new GameObject

            //2.
            //GameObject a = new GameObject();
            //GameObject b = a;
            //b = new GameObject();//重新给b分配了一个堆内存，b的地址指向新的堆
            //此时a和b有什么关系？
            //没有关系
            #endregion

            #region 成员变量和访问修饰符
            //1.访问修饰符有哪些，有什么用？
            //public 公共的，可以在外部调用
            //private 私有的，只能在class内部访问和使用，不写默认为private
            //protected 保护的，只能在class内部和子类中访问和使用

            //2.定义一个人类，有姓名、身高、年龄、家庭住址等特征
            //用人创建若干个对象
            //Person pe1 = new Person();
            //Person pe2 = new Person();

            //3.定义一个学生类，有姓名，学号，年龄，同桌等特征，有学习方法。
            //用学生类创建若干个学生
            //Student st1 = new Student();
            //Student st2 = new Student();

            //4.定义一个班级类，有专业名称、教室容量、学生等
            //创建一个班级对象
            //Classroom c1 = new Classroom();

            //5.
            //Person p = new Person();
            //p.age = 10;
            //Person p2 = new Person();
            //p2.age = 20;
            //请问p.age=?
            //=10  类对象直接相互独立

            //6.
            //Person p = new Person();
            //p.age = 10;
            //Person p2 = p;//p和p2指向同一堆内存
            //p2.age = 20;//堆中age修改为20
            //Console.WriteLine(p.age);
            //请问p.age=?
            //20

            //7.
            //Student s = new Student();
            //s.age = 10;
            //int age = s.age;
            //age = 20;
            //请问s.age=?
            //10

            //8.
            //Student s = new Student();
            //s.Deskmate = new Student();
            //s.Deskmate.age = 10;
            //Student s2 = s.Deskmate;
            //s2.age = 20;
            //请问s.Deskmate.age=?
            //20
            #endregion

            #region 成员方法
            //1.定义一个人类，有姓名、身高、年龄、家庭住址等特征，并为人类定义说话、走路、吃饭等方法
            Person p1 = new Person{name="张三", height=172f, age=20, position="郑州" };

            //2.定义一个学生类，有姓名，学号，年龄，同桌等特征，有学习、吃饭等方法。
            Student s1 = new Student();
            s1.name = p1.name;
            s1.sno = 232442408;
            s1.age = p1.age;
            s1.calories = p1.calories;
            s1.deskmate = new Student();
            Student s2 = s1.deskmate;
            s2.name = "李四";
            s2.sno = 232442410;
            s2.age = 19;
            s2.calories = s1.deskmate.calories;
            s2.deskmate = s1;

            //3.定义一个食物类，有名称、热量等特征，思考如何和人类以及学生联系起来
            Food f1 = new Food("盖浇饭", 500);
            Food f2 = new Food("面条", 700);
            Food f3 = new Food("包子", 300);


            p1.Speak(f1);
            p1.Walk();
            p1.Eat(f1);
            Console.WriteLine($"张三现在还有{p1.calories}热量");

            #endregion
        }
    }
}
