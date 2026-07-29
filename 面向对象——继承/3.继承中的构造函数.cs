namespace 继承_3.继承中的构造函数
{
    //1.有一个打工人基类，有工种、工作内容两个特征，一个工作方法，
    //程序员、策划、美术分别继承打工人
    //请用继承中的构造函数知识点，实例化三个对象，分别是程序员、策划、美术
    class Worker
    {
        public string profession {  get; set; }
        public string jobDuties {  get; protected set; }
        public Worker(string profession)
        {
            this.profession = profession;
        }
        public void Work()
        {
            Console.WriteLine($"{profession}的工作内容是{jobDuties}");
        }
    }
    class Programmer : Worker
    {
        public Programmer() : base("程序员")
        {
            this.jobDuties = "写代码";
        }
    }
    class Planner : Worker
    {
        public Planner() : base("策划")
        {
            this.jobDuties = "制作方案";
        }
    }
    class Artist : Worker
    {
        public Artist() : base("美术")
        {
            this.jobDuties = "绘制图形";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker w1 = new Programmer();
            Worker w2 = new Planner();
            Worker w3 = new Artist();
            w1.Work();
            w2.Work();
            w3.Work();
        }
    }
}
