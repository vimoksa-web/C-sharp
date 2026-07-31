namespace _1.Vob
{
    //1.真的鸭子嘎嘎叫，木头鸭子吱吱叫，橡皮鸭子唧唧叫
    class Duck
    {
        public virtual void Cry()
        {
            
        }
    }
    class RealDuck : Duck
    {
        public override void Cry()
        {
            Console.WriteLine("真的鸭子嘎嘎叫");
        }
    }
    class WoodDuck : Duck
    {
        public override void Cry()
        {
            Console.WriteLine("木头鸭子吱吱叫");
        }
    }
    class RubberDuck : Duck
    {
        public override void Cry()
        {
            Console.WriteLine("橡皮鸭子唧唧叫");
        }
    }

    //2.所有员工九点打卡，但经理十一点打卡，程序员不打卡
    class Employees
    {
        public virtual void Check()
        {
            Console.WriteLine("员工九点打卡");
        }
    }
    class Manager : Employees
    {
        public override void Check()
        {
            Console.WriteLine("经理十一点打卡");
        }
    }
    class Programmer : Employees
    {
        public override void Check()
        {
            Console.WriteLine("程序员不用打卡");
        }
    }

    //3.创建一个图形类，有求面积和周长两个方法
    //创建矩形类、正方形类、圆形类继承图形类，实例化它们求其面积和周长
    class Graphic
    {
        public string name;
        public Graphic(string name)
        {
            this.name = name;
        }

        public virtual void Area()
        {

        }
        public virtual void Perimeter()
        {

        }
    }
    class Rectangle : Graphic
    {
        public int length { set; get; }
        public int width { set; get; }
        public Rectangle(int length, int width) : base("矩形")
        {
            this.length = length;
            this.width = width;
        }
        public override void Area()
        {
            Console.WriteLine($"{name}的面积为{length * width}");
        }
        public override void Perimeter()
        {
            Console.WriteLine($"{name}的周长为{(length + width) * 2}");
        }
    }
    class Square : Graphic
    {
        public int length { set; get; }
        public Square(int length) : base("正方形")
        {
            this.length = length;
        }
        public override void Area()
        {
            Console.WriteLine($"{name}的面积为{length * length}");
        }
        public override void Perimeter()
        {
            Console.WriteLine($"{name}的面积为{length * 4}");
        }
    }
    class Circle : Graphic
    {
        public static float PI = 3.14f;
        public int radius { set; get; }
        public Circle(int radius) : base("圆形")
        {
            this.radius = radius;
        }
        public override void Area()
        {
            Console.WriteLine($"{name}的面积为{(radius * radius * PI):F2}");
        }
        public override void Perimeter()
        {
            Console.WriteLine($"{name}的周长为{(2 * radius * PI):F2}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            Duck d1 = new RealDuck();
            Duck d2 = new WoodDuck();
            Duck d3 = new RubberDuck();
            d1.Cry();
            d2.Cry();
            d3.Cry();

            //2.
            Employees e1 = new Employees();
            Employees m1 = new Manager();
            Employees p1 = new Programmer();
            e1.Check();
            m1.Check();
            p1.Check();

            //3.
            Graphic g1 = new Rectangle(5, 8);
            Graphic g2 = new Square(5);
            Graphic g3 = new Circle(5);
            g1.Area();
            g1.Perimeter();
            g2.Area();
            g2.Perimeter();
            g3.Area();
            g3.Perimeter();
        }
    }
}
