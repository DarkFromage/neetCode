using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neetCode
{
    internal class TwoSumSolution
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;

            while (numbers[left] + numbers[right] != target)
            {
                if (numbers[left] + numbers[right] < target) left++;
                if (numbers[left] + numbers[right] > target) right--;
            }
            return [left + 1, right + 1];
        }
    }
}
