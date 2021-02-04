using System;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2;
            
            var c = 100;

            dynamic aa = 1;
            aa++;
            Console.WriteLine(aa);
            
            aa = "123456";
            Console.WriteLine(aa.Length);
        }
    }
}