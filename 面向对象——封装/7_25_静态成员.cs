namespace _7_25_静态成员
{
    #region 静态成员
    //2.
    class Person
    {
        static private Person p1= new Person();
        private Person()
        {

        }

        static public Person P1
        {
            get { return p1; }
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 静态成员
            //1.请说出const和static的区别
            //相同点：都可以直接用类名点出来使用
            //不同点：
            //1.const必须初始化，不能修改，static没有这个规则
            //2.const只能修饰变量，static可以修饰很多
            //3.const不能在访问修饰符前，只能写在变量类型前，static不需要

            //2.请用静态成员相关知识实现
            //一个类对象，在整个应用程序的生命周期中，有且仅会有一个该对象的存在，
            //不能在外部实例化，直接通过该类类名就能够得到唯一的对象
            #endregion
        }
    }
}
