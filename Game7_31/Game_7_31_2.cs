namespace Test7_31_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.勇者打怪物
            //勇者攻击力为8~12之间的一个值
            //怪物防御为10，血量为20
            //在控制台中通过打印信息表现勇者打怪物的过程
            //描述怪物的掉血情况
            //伤害计算公式：攻击力小于防御力时，减血为0，否则减血攻击力和防御力的差值
            //知识点：循环，随机数

            //定义怪物的防御力，血量
            int Def = 10, Hp = 20;

            while (true)
            {
                //生成勇者的攻击力
                Random i = new Random();
                int Atk = i.Next(8, 13);

                //定义勇者造成的伤害
                int Damage = Atk - Def;
                if (Damage > 0)
                {
                    Hp = Hp - Damage;
                    Console.WriteLine("勇者造成了{0}点伤害，怪物还剩{1}点血", Damage, Hp);
                }
                else
                {
                    Console.WriteLine("勇者没有造成伤害");
                }

                Console.WriteLine("请按任意键继续");
                Console.ReadKey(true);
                Console.Clear();

                if (Hp <= 0)
                {
                    Console.WriteLine("勇者打倒了怪物");
                    break;
                }
            }
        }
    }
}
