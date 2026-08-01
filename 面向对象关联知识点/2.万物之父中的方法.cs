namespace _2.万物之父中的方法
{
    #region 第一题
    //1.有一个玩家类，有姓名、血量、攻击力、防御力、闪避率等特征，
    //请在控制台打印出“玩家XX，血量XX，攻击力XX，防御力XX”XX为具体内容
    class Player
    {
        public string name { get; set; }
        public int hp { get; set; }
        public int atk { get; set; }
        public int def { get; set; }
        public float dodge { get; set; }
        public Player()
        {
            name = "XD";
            hp = 100;
            atk = 10;
            def = 10;
            dodge = 0.3f;
        }
        public override string ToString()
        {
            return $"玩家{name}，血量{hp}，攻击力{atk}，防御力{def}，闪避率{dodge}";
        }
    }
    #endregion

    #region 第二题
    //2.一个Monster类的引用对象A，Monster类有攻击力、防御力、血量、技能ID等属性，
    //我想复制一个和对象A一模一样的B对象，并且改变了B的属性，A不会受到影响。请问如何实现
    class Monster
    {
        public string name { get; set; }
        public int atk { get; set; }
        public int def { get; set; }
        public int hp { get; set; }
        public string skill { get; set; }
        public Monster(string name)
        {
            this.name = name;
            atk = 15;
            def = 5;
            hp = 200;
            skill = "撼地";
        }
        public Monster Clone()
        {
            return MemberwiseClone() as Monster;
        }
        public override string ToString()
        {
            return $"怪物{name}，血量{hp}，攻击力{atk}，防御力{def}，技能{skill}";
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            Console.WriteLine(new Player());

            //2.
            Monster A = new Monster("A");
            Console.WriteLine($"怪物A的属性：{A}");
            Monster B = A.Clone();
            Console.WriteLine($"怪物B修改前的属性：{B}");
            B.hp = 300;
            B.name = "B";
            B.atk = 20;
            B.def = 10;
            B.skill = "毁天灭地";
            Console.WriteLine($"怪物B修改后的属性：{B}");
        }
    }
}
