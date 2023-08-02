using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.MargeSortedArray
{
    public class SolutionSortedArray
    {
        public void Marge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = nums1.Length - 1;
            int k = 0;

            while (i > 0)
            {
                if (nums1[i] > 0)
                    break;

                if (nums1[i] == 0)
                    nums1[i] = nums2[k++];

                i--;
            }

            Array.Sort(nums1);
        }
    }
}
//[-1,0,0,3,3,3,0,0,0]

//Input:
//nums1 = [1, 2, 3, 0, 0, 0], m = 3
//nums2 = [2, 5, 6],       n = 3

//Output: [1,2,2,3,5,6]
