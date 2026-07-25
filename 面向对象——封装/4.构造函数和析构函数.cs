namespace Test8_20_构造函数和析构函数
{
    //1.定义一个人类，有姓名、身高、年龄等特征，
    //并为人类定义说话、走路、吃饭等方法
    //对人类的构造函数进行重载，用人类创建若干个对象

    class Person
    {
        public void Speak()
        {

        }
        public void IsWalk()
        {

        }
        public void Eat()
        {

        }

        public string name;
        public float height;
        public int age;

        public Person(string name, float height, int age)
        {
            this.name = name;
            this.height = height;
            this.age = age;
        }
    }

    //2.定义一个班级类，有专业名称、教室容量、学生等，
    //对班级类的构造函数进行重载，创建若干个班级对象
    class Class
    {
        public string major;
        public int capacity;
        public Person[] students;

        public Class()
        {
            this.students = new Person[10];
        }
        public Class(string major, int capacity)
        {
            this.major = major;
            this.capacity = capacity;
            this.students = new Person[capacity];
        }
    }

    //3.写一个Ticket类，有一个距离变量(在构造对象时赋值，不能为负数)，有一个价格特征，
    //有一个方法GetPrice可以读取到价格，并且根据距离distance计算价格price(1元/公里)
    //0~100公里 不打折
    //101~200公里 打9.5折
    //201~300公里 打9折
    //300公里以上 打八折
    //有一个显示方法，可以显示这张票的信息。
    //例如：100公里100块钱
    class Ticket
    {
        public void GetPrice()
        {
            if (distance >= 0 && distance <= 100)
            {
                sumPrice = distance;
            }
            else if (distance > 100 && distance <= 200)
            {
                sumPrice = 0.95f * distance;
            }
            else if (distance > 200 && distance <= 300)
            {
                sumPrice = 0.9f * distance;
            }
            else
            {
                sumPrice = 0.8f * distance;
            }
        }

        public void PrintPrice()
        {
            Console.WriteLine("{0}公里{1}块钱", distance, sumPrice);
        }

        public uint distance;
        public int price;
        public float sumPrice;

        //重载
        public Ticket(uint distance)
        {
            this.distance = distance;
            GetPrice();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            Person p1 = new Person("张三", 1.78f, 23);
            Person p2 = new Person("李四", 1.68f, 20);

            //2.
            Class c1 = new Class("软件工程", 35);
            Class c2 = new Class("计算机科学与技术", 40);
            c1.students[0] = p1;
            c2.students[0] = p2;

            //3.
            Ticket t1 = new Ticket(60);
            t1.PrintPrice();
            Ticket t2 = new Ticket(160);
            t2.PrintPrice();
            Ticket t3 = new Ticket(260);
            t3.PrintPrice();
            Ticket t4 = new Ticket(360);
            t4.PrintPrice();
        }
    }
}
