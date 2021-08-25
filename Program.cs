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

            Console.ReadKey(); Console.WriteLine("NUMBER OF WAYS IN A GRID");
            //PROGRAM 2 -> GridTravel -> Slow version (fast not working) 
            GridTravel gridTravel = new GridTravel();
            Console.WriteLine(gridTravel.Grid(1, 1));      //1
            Console.WriteLine(gridTravel.Grid(2, 3));      //3
            Console.WriteLine(gridTravel.Grid(3, 2));      //3 
            Console.WriteLine(gridTravel.Grid(3, 3));      //6

            //TODO: NOT WORKING Console.WriteLine(gridTravel.Grid(18, 18));    //2333606220

            Console.ReadKey(); Console.WriteLine("CAN SUM TO THE TARGET");

            CanSumTheNumberFromArray cs = new CanSumTheNumberFromArray();
            int[] arr1 = { 2, 3 }; Console.WriteLine(cs.Sum(7, arr1)); //false
            int[] arr2 = { 2, 9 }; Console.WriteLine(cs.Sum(7, arr2)); //false
            int[] arr3 = { 2, 4 }; Console.WriteLine(cs.Sum(7, arr3)); //false
            Console.WriteLine();
            int[] arr4 = { 2, 3,5 }; Console.WriteLine(cs.Sum(8, arr4)); //true
            int[] arr4_4 = { 1,2,5 }; Console.WriteLine(cs.Sum(10, arr4_4)); //false 
            int[] arr4_8 = { 1,2,3,4,5 }; Console.WriteLine(cs.Sum(12, arr4_8)); //true 
            Console.WriteLine();
            int[] arr5 = { 7, 14 }; Console.WriteLine(cs.Sum(300, arr5)); //false
            int[] arr5_5_5 = { 7, 14 }; Console.WriteLine(cs.Sum(25600, arr5_5_5)); //false
            Console.WriteLine();
            int[] arr5_5 = { 1, 2, 3, 5, 5, 6, 7, 8, 9, 9999, 30595, 99573 }; Console.WriteLine(cs.Sum(300, arr5_5)); //SHOULD BE FALSE, idk why true

            int[] arr5_5_10 = { -6, -51,53,4 }; Console.WriteLine(cs.Sum(0, arr5_5_10)); //true
            int[] arr6 = { 7, 14,300 }; Console.WriteLine(cs.Sum(300, arr6)); //true
            int[] arr7 = { 1, 14, 286 }; Console.WriteLine(cs.Sum(300, arr7)); //true

            Console.ReadKey(); Console.WriteLine("HOW TO SUM TO THE TARGET");

            HowSumTheTargetFromArray hs = new HowSumTheTargetFromArray();
            int[] array1 = { 1, 14, 286 }; Console.WriteLine(hs.HowSum(28, array1.Length-1,array1)); //2 ways  NOT WORKING, idk why
            int[] array2 = { 5, 3, -6, 2 }; Console.WriteLine(hs.HowSum(6, array2.Length-1,array2)); //4 ways
            int[] array3 = { 44, 12,1000 }; Console.WriteLine(hs.HowSum(15, array3.Length-1,array3)); //0


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
