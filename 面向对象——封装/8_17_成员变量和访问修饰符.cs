using System.Security.Cryptography;

namespace Test8_17_成员变量和访问修饰符
{
    //1.定义一个人类，有姓名、身高、年龄、家庭住址等特征，
    //用人创建若干个对象
    class Person
    {
        public string name;
        public int height;
        public int age;
        public string adress;
    }

    //2.定义一个学生类，有姓名、学号、年龄、同桌等特征，
    //用学生类创建若干个学生
    class Student
    {
        public string name;
        public int number;
        public int age;
        public Student deskMate;
    }

    //3.定义一个班级类，有专业名称、教室容量、学生等，
    //创建一个班级对象
    class Classes
    {
        public string major;
        public int capacity;
        public Student[] student;
    }

    internal class Program
    {
        static void LearnMethod()
        {

        }
        static void Main(string[] args)
        {
            //1.
            //Person p1 = new Person();
            //p1.name = "XD";
            //p1.height = 175;
            //p1.age = 23;
            //p1.adress = "河南";
            //Person p2 = new Person();
            //p2.name = "A";
            //p2.height = 165;
            //p2.age = 21;
            //p2.adress = "AA";

            //2.
            //Student s1 = new Student();
            //s1.name = "Q";
            //s1.number = 123456;
            //s1.age = 22;
            //Student s2 = new Student();
            //s2.name = "Z";
            //s2.number = 456789;
            //s2.age = 20;

            //s1.deskMate = s2;
            //s2.deskMate = s1;

            //3.
            //Classes c1 = new Classes();
            //c1.major = "软件工程";
            //c1.capacity = 30;
            //c1.student = new Student[] { s1, s2 };

            //4.
            //Person p1 = new Person();
            //p1.age = 10;
            //Person p2 = new Person();
            //p2.age = 20;

            //请问p1.age为多少
            //10

            //5.
            //Person p1 = new Person();
            //p1.age = 10;
            //Person p2 = p1;
            //p2.age = 20;

            //请问p1.age为多少
            //20


            //6.
            //Student s1 = new Student();
            //s1.age = 10;
            //int age = s1.age;
            //age = 20;

            //请问s1.age为多少
            //10


            //7.
            Student s1 = new Student();
            s1.deskMate = new Student();
            s1.deskMate.age = 10;
            Student s2 = s1.deskMate;
            s2.age = 20;

            //请问s1.deskmate.age为多少
            //20

        }
    }
}
