using System;

namespace Dynamic_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();

            Console.ReadKey();
            watch.Start();
            Console.WriteLine(FibRecursive(40));
            watch.Stop();
            Console.WriteLine(($"Execution Time: {watch.ElapsedMilliseconds} ms"));

            Console.ReadKey();
            watch.Start();
            Console.WriteLine(FibNotRecursive(40));
            watch.Stop();
            Console.WriteLine(($"Execution Time: {watch.ElapsedMilliseconds} ms"));

            Console.ReadKey();
            watch.Start();
            Console.WriteLine(FibDynamicProgramming(40));
            watch.Stop();
            Console.WriteLine(($"Execution Time: {watch.ElapsedMilliseconds} ms"));
        }

        public static int FibRecursive(int number)
        {
            if((number ==0 || number == 1))
                return number;
            else
                return (FibRecursive(number-1)+ FibRecursive(number-2));
        }

        public static int FibNotRecursive(int number)
        {
            int zero = 0, one = 1, next = 0;
            if(number == 0)
                return zero;

            for (int i = 2;  i <= number; i++){
                next = zero + one;
                zero = one;
                one = next;
            }
            return one;
        }

        static long[] cache = new long[200];
        public static long FibDynamicProgramming(long number)
        {
            if(number < 2)
                cache[number] = 1;
            if (cache[number] == 0)
                cache[number] = FibDynamicProgramming(number - 1) + FibDynamicProgramming(number - 2);
            return cache[number];
        }
    }
}
