namespace 面向对象_继承
{
    //1.写一个人类，人类中有姓名、年龄属性，有说话行为
    //战士继承人类，有攻击行为
    class Person
    {
        public string name { get; set; }
        public int age {  get; set; }
        public Person()
        {
            name = "无名";
            age = 0;
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void Speak()
        {
            Console.WriteLine($"你好，我是{name}");
        }
    }
    class Warrior : Person
    {
        public Warrior(string name, int age) : base(name, age)
        {

        }
        public void Atk()
        {
            Console.WriteLine($"战士{name}发动了攻击");
        }
    }
    internal class 继承的基本规则
    {
        static void Main(string[] args)
        {
            Warrior w1 = new Warrior("壶", 18);
            w1.Speak();
            w1.Atk();
        }
    }
}
