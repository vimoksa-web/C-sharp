namespace _10.运算符重载
{
    #region 运算符重载
    //1.定义一个位置结构体或类，为其重载判断是否相同的运算符
    //(x1,y1)==(x2,y2)   =>   两个值相等时才为true
    struct Point
    {
        public int x;
        public int y;
        public static bool operator ==(Point a, Point b)
        {
            if (a.x == b.x && a.y == b.y)
                return true;
            else
                return false;
        }
        public static bool operator !=(Point a, Point b)
        {
            return !(a == b);
        }
    }

    //2.定义一个Vector类(x,y,z)，通过重载运算符实现以下运算：
    //(x1,y1,z1) + (x2,y2,z2) = (x1+x2,y1+y2,z1+z2)
    //(x1,y1,z1) - (x2,y2,z2) = (x1-x2,y1-y2,z1-z2)
    //(x1,y1,z1) * num = (x1*num,y1*num,z1*num)
    class Vector
    {
        public int x;
        public int y;
        public int z;
        public static Vector operator +(Vector v1, Vector v2)
        {
            Vector v = new Vector();
            v.x = v1.x + v2.x;
            v.y = v1.y + v2.y;
            v.z = v1.z + v2.z;
            return v;
        }
        public static Vector operator -(Vector v1, Vector v2)
        {
            Vector v = new Vector();
            v.x = v1.x - v2.x;
            v.y = v1.y - v2.y;
            v.z = v1.z - v2.z;
            return v;
        }
        public static Vector operator *(Vector v1, int num)
        {
            Vector v = new Vector();
            v.x = v1.x * num;
            v.y = v1.y * num;
            v.z = v1.z * num;
            return v;
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 运算符重载
            //1.
            Point p1 = new Point();
            p1.x = 1;
            p1.y = 1;
            Point p2 = new Point();
            p2.x = 1;
            p2.y = 1;
            if (p1 == p2)
                Console.WriteLine("p1==p2");
            else
                Console.WriteLine("p1!=p2");

            //2.
            Vector v1 = new Vector();
            v1.x = 5;
            v1.y = 5;
            v1.z = 5;
            Vector v2 = new Vector();
            v2.x = 2;
            v2.y = 2;
            v2.z = 2;

            int num = 3;
            Vector v3 = new Vector();

            v3 = v1 + v2;
            Console.WriteLine($"{v3.x}, {v3.y}, {v3.z}");
            v3 = v1 - v2;
            Console.WriteLine($"{v3.x}, {v3.y}, {v3.z}");
            v3 = v1 * num;
            Console.WriteLine($"{v3.x}, {v3.y}, {v3.z}");
            #endregion
        }
    }
}
