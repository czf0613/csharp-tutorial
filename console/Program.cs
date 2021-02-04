using System;

namespace console
{
    class Program
    {
        enum Test
        {
            Value1 = 0,
            Value2 = 1,
            Value3 = 2
        }

        enum Another
        {
            Value1 = 0,
            Value2 = 1
        }

        struct Test2
        {
            public int a;
            public int b;
        }

        static void Main(string[] args)
        {
            var a = Test.Value1;
            // a = Another.Value1;
        }
    }
}