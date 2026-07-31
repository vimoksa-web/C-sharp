namespace _2.抽象类和抽象方法
{
    //1.写一个动物抽象类，写一个子类
    //人叫、狗叫、猫叫
    abstract class Animal
    {
        public string name { get; set; }
        public Animal(string name)
        {
            this.name = name;
        }
        public abstract void Shout();
    }
    class Person : Animal
    {
        public Person() : base("人类") { }
        public override void Shout()
        {
            Console.WriteLine($"{name}哇哇叫");
        }
    }
    class Cat : Animal
    {
        public Cat() : base("猫咪") { }
        public override void Shout()
        {
            Console.WriteLine($"{name}喵喵叫");
        }
    }
    class Dog : Animal
    {
        public Dog() : base("大狗") { }
        public override void Shout()
        {
            Console.WriteLine($"{name}汪汪叫");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Animal p1 = new Person();
            Animal c1 = new Cat();
            Animal d1 = new Dog();
            p1.Shout();
            c1.Shout();
            d1.Shout();

        }
    }
}
