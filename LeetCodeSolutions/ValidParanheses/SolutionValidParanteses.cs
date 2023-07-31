using System.Collections.Generic;

namespace LeetCodeSolutions.ValidParanheses
{
    public class SolutionValidParanteses
    {
        public bool IsValid(string s)
        {
            while (s.Contains("()") || s.Contains("[]") || s.Contains("{}"))
            {
                s = s.Replace("()", "").Replace("[]", "").Replace("{}", "");
            }

            return s.Length == 0;
        }
    }
}

//()[]{} => true
//([)] => false
//{[]} => true