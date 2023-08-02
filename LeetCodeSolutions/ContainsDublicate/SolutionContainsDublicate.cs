using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.ContainsDublicate
{
    public class SolutionContainsDublicate
    {
        public bool ContainsDuplicate(int[] nums)
        {
            Array.Sort(nums);
            int n = nums.Length;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                    return true;
            }

            return false;
        }

    
    }
}
