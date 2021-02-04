using System;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = "123456789";
            var b = @"aa
123456";

            //“我今天去了 xx，花了xx元，买了xx。”
            var place = "超市";
            var price = 10.0;
            var thing = "衣服";

            var c = "我今天去了" + place + "，" + "花了" + price + "元，买了" + thing + "。";

            c = $"我今天去了{place}，花了{price}元，买了{thing}。";

            Console.WriteLine(c);
        }
    }
}