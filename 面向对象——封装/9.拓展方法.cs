namespace _9.拓展方法
{
    #region 拓展方法
    //1.为整型拓展一个求平方的方法
    static class Tools
    {
        public static int Square(this int s)
        {
            return s * s;
        }
        public static void Suicide(this Player p)
        {
            p.Hurt(10000);
        }
    }
    //2.写一个玩家类，包含姓名、血量、攻击力、防御力等特征，移动，受伤等方法，
    //为该玩家类拓展一个自杀的方法
    class Player
    {
        private string name;
        private int hp;
        private int atk;
        private int def;
        private int coordinates;
        public Player() : this("无名氏") { }
        public Player(string playerName)
        {
            name = playerName;
            hp = 100;
            atk = 5;
            def = 5;
            coordinates = 0;
        }
        public void Move(int i)
        {
            coordinates += i;
            Console.WriteLine($"{name}移动了{i}米,一共移动了{coordinates}米");
        }
        public void Hurt(int a)
        {
            int damage = a - def;
            if (damage < 0)
                damage = 0;
            hp -= damage;

            if (hp > 0)
            {
                Console.WriteLine($"{name}受到了攻击，剩余血量{hp}");
            }
            else
            {
                Console.WriteLine("你死了");
            }
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 拓展方法
            //1.
            int i = 10;
            Console.WriteLine(i.Square());

            //2.
            Player p1 = new Player();
            p1.Move(5);
            p1.Hurt(10);
            p1.Suicide();
            #endregion
        }
    }
}
