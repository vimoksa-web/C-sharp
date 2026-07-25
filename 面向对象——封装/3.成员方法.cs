namespace Test8_18_成员方法
{
    //1.定义一个人类，有姓名、身高、年龄等特征，
    //并为人类定义说话、走路、吃饭等方法
    //用人类创建对象
    class Person
    {
        public void Speak(string str)
        {
            Console.WriteLine("{0}说{1}", name, str);
        }

        public void Walk(bool isWalk)
        {
            Console.WriteLine(isWalk == true ? "{0}在走路" : "{0}没有在走路", name);
        }

        public void Eat(string str)
        {
            Console.WriteLine("{0}吃了{1}", name, str);
        }

        public string name;
        public float height;
        public int age;
    }

    //2.定义一个学生类，有姓名、学号、年龄、同桌等特征，
    //为学生类定义学习、吃饭等方法
    //用学生类创建学生
    enum E_Study
    {
        /// <summary>
        /// 看书
        /// </summary>
        ReadBook,
        /// <summary>
        /// 看视频
        /// </summary>
        WatchVideo,
        /// <summary>
        /// 自学
        /// </summary>
        SelfStudy,
    }
    class Student
    {
        public void Study(E_Study study)
        {
            switch (study)
            {
                case E_Study.ReadBook:
                    Console.WriteLine("{0}看书学习", name);
                    break;
                case E_Study.WatchVideo:
                    Console.WriteLine("{0}看视频学习", name);
                    break;
                case E_Study.SelfStudy:
                    Console.WriteLine("{0}自学学习", name);
                    break;
            }
        }

        public void Eat()
        {

        }

        public string name;
        public int number;
        public int age;
        public Student deskmate;
    }

    //3.定义一个食物类，有名称、热量等特征，思考如何与人类、学生联系起来
    class Food
    {
        public void IsEat(Student s, Person p)
        {
            if (heat < 1400)
            {
                Console.WriteLine("{0}的热量不足以支撑{1}和{2}一天所需", name, s.name, p.name);
            }
            else if (heat >= 1400 && heat < 1700)
            {
                Console.WriteLine("{0}的热量适合{1}，对{2}来说太少", name, s.name, p.name);
            }
            else if (heat >= 1700 && heat < 2000)
            {
                Console.WriteLine("{0}的热量适合{2}，对{1}来说太多", name, p.name, s.name);
            }
            else
            {
                Console.WriteLine("{0}的热量太多了，对{1}和{2}不健康", name, s.name, p.name);
            }
        }

        public string name;
        public int heat;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            Person p1 = new Person();
            p1.name = "张三";
            p1.height = 1.75f;
            p1.age = 19;
            p1.Speak("你好");
            p1.Walk(true);
            p1.Eat("黄焖鸡米饭");
            Console.WriteLine("---------------------------");

            //2.
            Student s1 = new Student();
            s1.name = "李四";
            s1.number = 123456;
            s1.age = 18;
            Student s2 = new Student();
            s2.name = "王二";
            s2.number = 456789;
            s2.age = 20;
            s1.deskmate = s2;
            s2.deskmate = s1;

            s1.Study(E_Study.ReadBook);
            s2.Study(E_Study.WatchVideo);
            Console.WriteLine("---------------------------");
            //3.
            Food f1 = new Food();
            f1.name = "糖醋里脊";
            f1.heat = 7500;
            Food f2 = new Food();
            f2.name = "全麦吐司";
            f2.heat = 1000;
            Food f3 = new Food();
            f3.name = "沙拉";
            f3.heat = 1500;
            Food f4 = new Food();
            f4.name = "压缩饼干";
            f4.heat = 1800;

            f1.IsEat(s1, p1);
            f2.IsEat(s1, p1);
            f3.IsEat(s1, p1);
            f4.IsEat(s1, p1);
        }
    }
}
