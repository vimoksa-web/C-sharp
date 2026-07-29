namespace _5.密封类
{
    //1.定义一个载具类，有速度、最大速度、可乘人数、司机和乘客等，
    //有上车、下车、行驶、车祸等方法，用载具类声明一个对象，并将若干人装载上车
    //载具类
    class Vehicle
    {
        public float speed {  get; protected set; }
        public int maxSpeed { get; protected set; }
        public int capacity { get; protected set; }
        public string driver { get; protected set; }
        public Passenger[] passengers { get; protected set; }
        private bool isSpeeding;
        public Vehicle(Passenger[] passengers)
        {
            speed = 0;
            maxSpeed = 120;
            capacity = 30;
            driver = "王师傅";
            this.passengers = passengers;
            isSpeeding = false;
        }
        //上车
        public void GetOn(Passenger passenger)
        {
            if (passenger == null) return;
            if (passengers.Length >= capacity)
            {
                Console.WriteLine("最大容量30人，没有空位了");
                return;
            }
            Passenger[] arr = new Passenger[passengers.Length + 1];
            for (int i = 0; i < passengers.Length; i++)
            {
                arr[i] = passengers[i];
            }
            arr[passengers.Length] = passenger;
            passengers = arr;
        }
        //下车
        public void GetOff()
        {
            if (passengers == null || passengers.Length == 0)
            {
                Console.WriteLine("车上没有乘客");
                return;
            }
            Passenger[] arr = new Passenger[passengers.Length - 1];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = passengers[i];
            }
            passengers = arr;
        }
        //行驶
        public void Driving(int time)
        {
            speed = 1.2f * time;
            if (speed >= maxSpeed)
            {
                speed = maxSpeed;
                Console.WriteLine($"已达最大车速{maxSpeed}");
            }
            if (speed > 100)
            {
                isSpeeding = true;
                Console.WriteLine($"当前车速为{speed:F2}，您已超速");
                return;
            }
            else
                isSpeeding = false;
            Console.WriteLine($"经过{time}分钟，当前车速为{speed:F2}");
        }
        //车祸
        public void Accident()
        {
            if (isSpeeding)
            {
                Console.WriteLine("出车祸了");
                if (passengers == null || passengers.Length == 0)
                {
                    Console.WriteLine("车上没有乘客，没有伤亡");
                    return;
                }
                Passenger[] arr = new Passenger[passengers.Length / 2];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = passengers[i];
                }
                passengers = arr;
                Console.WriteLine("车上伤亡一半人");
            }
            else
            {
                Console.WriteLine("遵纪守法，没有发生车祸");
            }
        }
    }
    //乘客
    class Passenger
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Passenger p1 = new Passenger();
            Passenger p2 = new Passenger();
            Passenger p3 = new Passenger();
            Passenger p4 = new Passenger();
            Passenger p5 = new Passenger();
            Passenger p6 = new Passenger();
            Passenger p7 = new Passenger();
            Passenger p8 = new Passenger();
            Passenger p9 = new Passenger();
            Passenger p10 = new Passenger();
            Passenger[] ps = { p1, p2, p3, p4, p5, p6, p7, p8, p9, p10 };
            Passenger p11 = new Passenger();
            Vehicle v1 = new Vehicle(ps);
            v1.GetOn(p11);
            v1.GetOff();
            v1.Driving(60);
            v1.Accident();
        }
    }
}
