namespace _1
{
    //1.is和as的区别
    //is用于判断对象是否是指定类，是返回true，不是返回false
    //as用于转换为指定对象，转换成功返回指定对象，失败返回null

    //2.写一个Monster类，它派生出Boss和Goblin类，Boss有技能，小怪有攻击，
    //随机生成十个怪装载到数组中，遍历这个数组，调用他们的攻击方法，如果是Boss就施放技能
    class Monster
    {

    }
    class Boss : Monster
    {
        public void BossSkill()
        {
            Console.WriteLine("Boss释放了技能");
        }
    }
    class Goblin : Monster
    {
        public void GoblinAtk()
        {
            Console.WriteLine("哥布林发动了攻击");
        }
    }

    //3.Fps游戏模拟，写一个玩家类，玩家可以有各种武器，
    //现在有四种武器，冲锋枪，霰弹枪，手枪，匕首，玩家默认拥有匕首，
    //请在玩家类中写一个方法，可以拾取不同的武器替换自己拥有的枪械
    //enum Weapons
    //{
    //    knife,
    //    pistol,
    //    submachinegun,
    //    shotgun,
    //}
    //class Player
    //{
    //    protected Weapons weapon;
    //    public Player()
    //    {
    //        weapon = Weapons.knife;
    //    }
    //    public void ChangeWeapon(Weapons w)
    //    {
    //        if (w == weapon)
    //        {
    //            Console.WriteLine($"您已经拥有{w}了");
    //            return;
    //        }
    //        this.weapon = w;
    //        Console.WriteLine($"将武器更换为{w}");
    //    }
    //}

    class Weapons
    {
        public string weaponsName {  get; set; }
        protected Weapons(string name)
        {
            weaponsName = name;
        }
    }
    class Knife : Weapons
    {
        public Knife() : base("knife") { }
    }
    class Pistol : Weapons
    {
        public Pistol() : base("pistol") { }
    }
    class Submachinegun : Weapons
    {
        public Submachinegun() : base("Submachinegun") { }
    }
    class Shotgun : Weapons
    {
        public Shotgun() : base("Shotgun") { }
    }
    class Player
    {
        public Weapons playerWeapon {  get; private set; }
        public Player()
        {
            playerWeapon = new Knife();
        }
        public void ChangeWeapon(Weapons newWeapon)
        {
            if (playerWeapon == null)
                return;
            if (playerWeapon != null && newWeapon.weaponsName == playerWeapon.weaponsName)
            {
                Console.WriteLine($"你已经拥有{newWeapon.weaponsName}了");
                return;
            }
            Console.WriteLine($"将{playerWeapon.weaponsName}替换为{newWeapon.weaponsName}");
            playerWeapon = newWeapon;
        }
    }
    internal class 里氏替换原则
    {
        static void Main(string[] args)
        {
            //2.
            Monster[] monsters = new Monster[10] {new Goblin(), new Goblin(), new Boss(), new Goblin(), new Goblin(),
                                                  new Goblin(), new Boss(), new Goblin(), new Goblin(), new Goblin(), };
            for (int i = 0; i < monsters.Length; i++)
            {
                if (monsters[i] is Goblin)
                {
                    (monsters[i] as Goblin).GoblinAtk();
                }
                else if (monsters[i] is Boss)
                {
                    (monsters[i] as Boss).BossSkill();
                }
            }

            //3.
            //Player p = new Player();
            //p.ChangeWeapon(Weapons.knife);
            //p.ChangeWeapon(Weapons.pistol);
            //p.ChangeWeapon(Weapons.submachinegun);
            //p.ChangeWeapon(Weapons.shotgun);

            Player player = new Player();
            player.ChangeWeapon(new Knife());
            player.ChangeWeapon(new Pistol());
            player.ChangeWeapon(new Submachinegun());
            player.ChangeWeapon(new Shotgun());
        }
    }
}
