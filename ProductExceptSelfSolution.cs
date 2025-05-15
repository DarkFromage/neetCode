using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neetCode
{
    internal class ProductExceptSelfSolution
    {
        public int[] ProductExceptSelf(int[] nums) 
        {
            int[] result = new int[nums.Length];
            int coef = 0;
            int Zero = 0;
            for(int i=0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    Zero++;
                }
                else
                {
                    if (coef == 0) coef = 1;
                    coef *= nums[i];
                    result[i] = nums[i];
                }
            }
            for(int i = 0; i < result.Length; i++)
            {
                if (result[i] == 0 && Zero <= 1) result[i] = coef;
                else if (Zero > 1 || result[i] != 0 && Zero == 1) result[i] = 0;
                else result[i] = coef / result[i];

            }
            return result;
        }
    }
}
