using System;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[100];
            for (var i = 0; i < 100; ++i)
                array[i] = i;

            //切片
            int[] slice = array[1..10];
            foreach (var i in slice)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(array[^1]);
        }
    }
}