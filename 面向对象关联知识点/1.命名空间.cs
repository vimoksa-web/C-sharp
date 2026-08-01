#region 第一题
//1.请说明关键字using有什么作用
//引出namespace，快捷调用，不需要再点出使用
#endregion

#region 第二题
//2.有两个命名空间，UI(用户界面)和Graph(图表)
//两个命名空间中都有一个Image类，请在主函数中实例化两个不同命名空间中的Image对象
namespace UI
{
    class Image
    {

    }
}
namespace Graph
{
    class Image
    {

    }
}
#endregion
namespace _1.命名空间
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.
            UI.Image im1 = new UI.Image();
            Graph.Image im2 = new Graph.Image();
        }
    }
}
