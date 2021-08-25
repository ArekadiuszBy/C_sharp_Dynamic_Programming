using System;
using System.Collections.Generic;

namespace Dynamic_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();

            watch.Start();
            Console.WriteLine(FibRecursive(40));
            watch.Stop();
            Console.WriteLine(($"Execution Time: {watch.ElapsedMilliseconds} ms"));

            watch.Start();
            Console.WriteLine(FibNotRecursive(40));
            watch.Stop();
            Console.WriteLine(($"Execution Time: {watch.ElapsedMilliseconds} ms"));

            watch.Start();
            Console.WriteLine(FibDynamicProgramming(40));
            watch.Stop();
            Console.WriteLine(($"Execution Time: {watch.ElapsedMilliseconds} ms"));

            Console.ReadKey();
            //PROGRAM 2 -> GridTravel -> Slow version (fast not working) 
            GridTravel gridTravel = new GridTravel();
            Console.WriteLine(gridTravel.Grid(1, 1));      //1
            Console.WriteLine(gridTravel.Grid(2, 3));      //3
            Console.WriteLine(gridTravel.Grid(3, 2));      //3 
            Console.WriteLine(gridTravel.Grid(3, 3));      //6

            //TODO: NOT WORKING Console.WriteLine(gridTravel.Grid(18, 18));    //2333606220

            Console.ReadKey();

            CanSumTheNumberFromArray cs = new CanSumTheNumberFromArray();
            Console.WriteLine(cs.Sum(7, [2, 3])); //true
            Console.WriteLine(cs.Sum(7, [5,3,4,7])); //true
            Console.WriteLine(cs.Sum(7, [2,4])); //false
            Console.WriteLine(cs.Sum(8, [2,3,5])); //true
            Console.WriteLine(cs.Sum(300, [7,14])); //false
            Console.WriteLine(cs.Sum(300, [7,14,300])); //true
            Console.WriteLine(cs.Sum(300, [7,14,286])); //true

            Console.ReadKey();


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
            if(number < 3)
                cache[number]=1;
            if (cache[number] == 0)
                cache[number] = FibDynamicProgramming(number - 1) + FibDynamicProgramming(number - 2);
            return cache[number];
        }
    }
}
