using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Programming
{
    class CanSumTheNumberFromArray
    {
        public bool Sum(int number, int[] arr)
        {
            bool end = false;

            int sum = 0;
            for (int i = 0;i<arr.Length;i++)
                sum+=arr[i];

            if (sum < number)
                return false;
            else
            {
                end = Sum2(number, arr);
            }
            return end;
        }

        int target;
        public bool Sum2(int number, int[] arr)
        {
            if (target == 0) return true;
            int len = arr.Length - 1;

            foreach(var x in arr)
            {
                int remainder = target - x;
                if(Sum2(remainder,arr) == true)
                    return true;
            }
            return false;   
        }
    }
}
