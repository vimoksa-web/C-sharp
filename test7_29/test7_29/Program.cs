using System;

namespace test7_29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.老师的工资是由基本工资 + 绩效决定的
            //绩效说明：
            //学生评价很兴奋 则评定为A级 绩效工资500
            //学生评价很充实 则评定为B级 不加绩效工资
            //学生评价还好吧 则评定为C级 绩效工资扣300
            //学生评价难理解 则评定为D级 绩效工资扣500
            //学生评价枯燥乏味 则评定为E级 绩效工资扣800
            //假设王老师的工资是4000，请输入王老师的评级，并算出王老师的工资是多少
            //try
            //{
            //    int money = 4000;
            //    Console.WriteLine("请输入王老师的评级：");
            //    char jiXiao = char.Parse(Console.ReadLine());
            //    switch (jiXiao)
            //    {
            //        case 'A':
            //            Console.WriteLine("王老师的工资是{0}", money + 500);
            //            break;
            //        case 'B':
            //            Console.WriteLine("王老师的工资是{0}", money);
            //            break;
            //        case 'C':
            //            Console.WriteLine("王老师的工资是{0}", money - 300);
            //            break;
            //        case 'D':
            //            Console.WriteLine("王老师的工资是{0}", money - 500);
            //            break;
            //        case 'E':
            //            Console.WriteLine("王老师的工资是{0}", money - 800);
            //            break;
            //        default:
            //            Console.WriteLine("请输入相应的评级字符");
            //            break;
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("请输入正确的格式");
            //}


            //2.小唐带了10元去买星巴克，有三种规格可以选择
            //1 = (中杯 ￥5)
            //2 = (大杯 ￥7)
            //3 = (超大杯 ￥11)
            //请用户输入选择的规格，如果钱够则购买成功，并算出小唐最后还剩多少钱
            //如果钱不够，则提示用户"钱不够，请选择其他规格"
            //try
            //{
            //    Console.WriteLine("请选择一种规格(1/2/3)");
            //    int guiGe = int.Parse(Console.ReadLine());
            //    switch (guiGe)
            //    {
            //        case 1:
            //            Console.WriteLine("购买成功，您还剩{0}元", 10 - 5);
            //            break;
            //        case 2:
            //            Console.WriteLine("购买成功，您还剩{0}元", 10 - 7);
            //            break;
            //        case 3:
            //            Console.WriteLine("钱不够，请选择其他规格");
            //            break;
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("请输入正确的格式");
            //}


            //3.输入学生的考试成绩，如果成绩>=90：A
            //90 > 成绩 >= 80: B
            //80 > 成绩 >= 70: C
            //70 > 成绩 >= 60: D
            //成绩 < 60: E
            //使用switch语句完成，最后输出学生的考试等级
            try
            {
                Console.WriteLine("请输入学生的考试成绩：");
                int Score = int.Parse(Console.ReadLine());
                Score /= 10;
                switch (Score)
                {
                    case 10:
                    case 9:
                        Console.WriteLine("学生的考试等级为A");
                        break;
                    case 8:
                        Console.WriteLine("学生的考试等级为B");
                        break;
                    case 7:
                        Console.WriteLine("学生的考试等级为C");
                        break;
                    case 6:
                        Console.WriteLine("学生的考试等级为D");
                        break;
                    default:
                        Console.WriteLine("学生的考试等级为E");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("请输入正确的格式");
            }

            //4.在控制台输入一个0~9的数并显示为大写。如输入2，则显示二
            //try
            //{
            //    Console.WriteLine("请输入一个0~9的数：");
            //    int i = int.Parse(Console.ReadLine());
            //    switch (i)
            //    {
            //        case 0:
            //            Console.WriteLine("零");
            //            break;
            //        case 1:
            //            Console.WriteLine("一");
            //            break;
            //        case 2:
            //            Console.WriteLine("二");
            //            break;
            //        case 3:
            //            Console.WriteLine("三");
            //            break;
            //        case 4:
            //            Console.WriteLine("四");
            //            break;
            //        case 5:
            //            Console.WriteLine("五");
            //            break;
            //        case 6:
            //            Console.WriteLine("六");
            //            break;
            //        case 7:
            //            Console.WriteLine("七");
            //            break;
            //        case 8:
            //            Console.WriteLine("八");
            //            break;
            //        case 9:
            //            Console.WriteLine("九");
            //            break;
            //        default:
            //            Console.WriteLine("请输入正确范围内的数字");
            //            break;
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("请输入正确的格式");
            //}
        }
    }
}
