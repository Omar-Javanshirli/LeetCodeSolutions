using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.ThreeSum
{
    public class SolutionThreeSum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> ar = new List<IList<int>>();
            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;

                int left = i + 1;
                int right = nums.Length - 1;

                while (left < right)
                {
                    int total = nums[i] + nums[left] + nums[right];

                    if (total == 0)
                    {
                        ar.Add(new List<int> { nums[i], nums[left], nums[right] });

                        while (left < right && nums[left] == nums[left + 1])
                            left++;

                        while (left < right && nums[right] == nums[right - 1])
                            right--;

                        left++;
                        right--;
                    }
                    else if (total < 0)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }

            if (ar.Count(item => item.Count(x => x == 0) == 3) == 0)
                ar.Add(new List<int> { 0, 0, 0 });

            return ar;
        }

    }
}
//[-1,0,1,2,-1,-4]