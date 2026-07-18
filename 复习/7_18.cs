namespace _7_18
{
    #region 构造函数和析构函数
    //1.写一个Ticket类，有一个距离变量（在构造对象时赋值，不能为负数），有一个价格特征，
    //有一个方法GetPrice可以读取到价格，并且根据距离distance可以计算价格price（1元/公里）
    //0~100公里 不打折
    //101~200公里 打9.5折
    //201~300公里 打9折
    //300公里以上 打8折
    //有一个显示方法可以显示这张票的信息
    //例如：100公里100块钱
    class Ticket
    {
        public int distance;
        private float price;
        //构造函数
        public Ticket(int distance)
        {
            if (distance < 0)
                throw new ArgumentException("距离不能为负数");
            this.distance = distance;
            this.price = Price();
        }
        //计算价格
        private float Price()
        {
            return this.price = distance switch
            {
                >= 0 and <= 100 => distance * 1f,
                > 100 and <= 200 => distance * 0.95f,
                > 200 and <= 300 => distance * 0.9f,
                > 300 => distance * 0.8f,
                _ => throw new ArgumentException()
            };
        }
        //返回价格
        public float GetPrice()
        {
            return this.price;
        }
        //打印信息
        public void TicketInfo()
        {
            Console.WriteLine($"{this.distance}公里{this.price:F2}块钱");
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 构造函数和析构函数
            //1.
            Ticket t1 = new Ticket(385);
            t1.TicketInfo();
            #endregion
        }
    }
}
