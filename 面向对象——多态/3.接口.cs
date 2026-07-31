using System.Xml.Linq;

namespace _3.接口
{
    #region 第一题
    //1.人、汽车、房子都需要登记，人到派出所登记，汽车到车管所登记，房子到房管局登记。
    //请使用接口实现统一的登记方法。
    interface IRegister
    {
        void Register();
    }
    class Person : IRegister
    {
        public void Register()
        {
            Console.WriteLine("人到派出所登记");
        }
    }
    class Car : IRegister
    {
        public void Register()
        {
            Console.WriteLine("车到车管所登记");
        }
    }
    class House : IRegister
    {
        public void Register()
        {
            Console.WriteLine("房到房管局登记");
        }
    }
    #endregion

    #region 第二题
    //2.有麻雀、鸵鸟、企鹅、鹦鹉、直升机、天鹅这些对象。
    //直升机和部分鸟能飞（但鸵鸟和企鹅不能飞）。
    //企鹅和天鹅能游泳。
    //除直升机外，其他都能走。
    //请用面向对象相关知识实现，体现多态性。
    class Bird
    {
        public string name { get; set; }
        public Bird(string name)
        {
            this.name = name;
        }
    }
    interface IFly
    {
        void Fly();
    }
    interface ISwim
    {
        void Swim();
    }
    interface IWalk
    {
        void Walk();
    }
    class Sparrow : Bird, IFly, IWalk
    {
        public Sparrow() : base("麻雀") { }
        public void Fly()
        {
            Console.WriteLine($"{name}会飞");
        }
        public void Walk()
        {
            Console.WriteLine($"{name}会走");
        }
    }
    class Ostrich : Bird, IWalk
    {
        public Ostrich() : base("鸵鸟") { }
        public void Walk()
        {
            Console.WriteLine($"{name}会走");
        }
    }
    class Penguin : Bird, ISwim, IWalk
    {
        public Penguin() : base("企鹅") { }
        public void Swim()
        {
            Console.WriteLine($"{name}会游泳");
        }
        public void Walk()
        {
            Console.WriteLine($"{name}会走");
        }
    }
    class Parrot : Bird, IFly, IWalk
    {
        public Parrot() : base("鹦鹉") { }
        public void Fly()
        {
            Console.WriteLine($"{name}会飞");
        }
        public void Walk()
        {
            Console.WriteLine($"{name}会走");
        }
    }
    class Helicopter : IFly
    {
        public void Fly()
        {
            Console.WriteLine($"直升机会飞");
        }
    }
    class Swan : Bird, IFly, ISwim, IWalk
    {
        public Swan() : base("天鹅") { }
        public void Fly()
        {
            Console.WriteLine($"{name}会飞");
        }
        public void Swim()
        {
            Console.WriteLine($"{name}会游泳");
        }
        public void Walk()
        {
            Console.WriteLine($"{name}会走");
        }
    }
    #endregion

    #region 第三题
    //3.模拟移动硬盘、U盘、MP3插到电脑上读取数据。
    //移动硬盘与U盘都属于存储设备；
    //MP3属于播放设备；
    //但它们都能插在电脑上传输数据；
    //电脑提供了一个USB接口。
    //请实现电脑传输数据的功能，体现多态。
    abstract class Storage
    {
        public string name { get; protected set; }
        public Storage(string name)
        {
            this.name = name;
        }
    }
    interface IUsb
    {
        void TransferData();
    }
    class Harddrive : Storage, IUsb
    { 
        public Harddrive() : base("硬盘") { }
        public void TransferData()
        {
            Console.WriteLine($"电脑正在读取{name}中的数据");
        }
    }
    class Udrive : Storage, IUsb
    {
        public Udrive() : base("U盘") { }
        public void TransferData()
        {
            Console.WriteLine($"电脑正在向{name}中传输数据");
        }
    }
    class MP3 : IUsb
    { 
        public void TransferData()
        {
            Console.WriteLine($"电脑正在读取MP3的音乐歌单");
        }
    }
    class Computer
    {
        public void Insert(IUsb usb)
        {
            if (usb == null) return;
            Console.WriteLine("USB接口已连接");
            usb.TransferData();
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            IRegister r1 = new Person();
            IRegister r2 = new Car();
            IRegister r3 = new House();
            r1.Register();
            r2.Register();
            r3.Register();

            //3.
            Computer computer = new Computer();
            computer.Insert(new Harddrive());
            computer.Insert(new Udrive());
            computer.Insert(new MP3());

        }
    }
}
