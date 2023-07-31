using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.AddTwoNumbers
{
    public class SolutionAddTwoNumber
    {
        public ListNode AddTwoNumber(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null) return null;

            int val = (l1 == null ? 0 : l1.Data) + (l2 == null ? 0 : l2.Data);

            if (val >= 10)
            {
                val -= 10;
                if (l1.Next != null)
                    l1.Next.Data++;

                else l1.Next = new ListNode(1);
            }
            return new ListNode(val, AddTwoNumber(l1?.Next, l2?.Next));
        }
    }
}
