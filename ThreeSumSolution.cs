using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neetCode
{
    internal class ThreeSumSolution
    {
        public List<List<int>> ThreeSum(int[] nums)
        {
            nums = Quicksort(nums, 0, nums.Length - 1);

            int pivot;
            int left;
            int right;
            List<List<int>> result = new List<List<int>>();

            for ( pivot = 0; pivot < nums.Length - 2; pivot++)
            {
                right = nums.Length - 1;
                for (left = pivot + 1; left < right; left++)
                {
                    if (nums[pivot] + nums[left] + nums[right] == 0)
                    {
                        List<int> triplet = new List<int> { nums[pivot], nums[left], nums[right] };

                        bool exists = result.Any(r =>
                        r[0] == triplet[0] &&
                        r[1] == triplet[1] &&
                        r[2] == triplet[2]);

                        if (!exists) result.Add(triplet);
                    }
                    if (nums[pivot] + nums[left] + nums[right] > 0)
                    {
                        right--;
                        left--;
                    }
                }
            }
            return result;
        }

        private int[] Quicksort(int[] nums, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(nums, left, right);
                Quicksort(nums, left, pivotIndex - 1);
                Quicksort(nums, pivotIndex + 1, right);
            }
            return nums;

        }

        private int Partition(int[] nums, int left, int right)
        {
            int pivot = nums[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (nums[j] <= pivot)
                {
                    i++;
                    (nums[i], nums[j]) = (nums[j], nums[i]);
                }
            }

            (nums[i + 1], nums[right]) = (nums[right], nums[i + 1]);

            return i + 1;
        }
    }
}
