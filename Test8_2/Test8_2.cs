namespace Test8_2
{
    //1.定义QQ状态的枚举，并提示玩家选择一个在线状态，我们接受输入的数字，并将其转换为枚举类型
    enum E_QQstatus
    {
        Online,
        Busy,
        Stealth,
        Offline,
    }

    //2.星巴克买咖啡
    enum E_coffeeType
    {
        Middle,
        Big,
        Largest,
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //1.定义QQ状态的枚举，并提示玩家选择一个在线状态，我们接受输入的数字，并将其转换为枚举类型
            //try
            //{
            //    Console.WriteLine("请选择你的QQ在线状态(0在线，1忙碌，2隐身，3离线)");
            //    int status = int.Parse(Console.ReadLine());
            //    E_QQstatus userStatus = (E_QQstatus)status;
            //    Console.WriteLine(userStatus);
            //}
            //catch
            //{
            //    Console.WriteLine("请输入数字");
            //}
            

            //用户去星巴克买咖啡，分为中杯(35元)，大杯(40元)，超大杯(43元)，
            //请用户选择要购买的类型，用户选择后，打印：您购买了XXX咖啡，花费了XX元
            //例如：你购买了中杯咖啡，花费了35元
            try
            {
                Console.WriteLine("请输入您要购买的咖啡类型(0中杯，1大杯，2超大杯)");
                int cafeType = int.Parse(Console.ReadLine());
                E_coffeeType Type = (E_coffeeType)cafeType;
                switch (Type)
                {
                    case E_coffeeType.Middle:
                        Console.WriteLine("您购买了中杯咖啡，花费了35元");
                        break;
                    case E_coffeeType.Big:
                        Console.WriteLine("您购买了大杯咖啡，花费了40元");
                        break;
                    case E_coffeeType.Largest:
                        Console.WriteLine("您购买了超大杯咖啡，花费了43元");
                        break;
                    default:
                        break;
                }
            }
            catch
            {

            }
        }
    }
}
