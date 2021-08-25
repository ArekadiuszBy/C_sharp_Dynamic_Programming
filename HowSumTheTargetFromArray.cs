using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Programming
{
    class HowSumTheTargetFromArray
    {
        public int HowSum(int target, int n, int[] numbers)
        {
            //Get from techiedlight.com

            // base case: if a target is found
            if (target == 0)
            {
                return 1;
            }

            // base case: no elements are left
            if (n < 0)
            {
                return 0;
            }

            // 1. ignore the current element
            int exclude = HowSum(target, n - 1, numbers);

            // 2. Consider the current element

            // 2.1. Subtract the current element from the target
            // 2.2. Add the current element to the target
            int include = HowSum(target - numbers[n], n - 1, numbers) +
                        HowSum(target + numbers[n], n - 1, numbers);

            // Return total count
            return exclude + include;

        }
    }
}
