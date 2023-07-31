using System;
using System.Collections.Generic;

namespace LeetCodeSolutions.LongestSubstringWithoutRepating
{
    public class SolutionLongestSubstringWitoutRepating
    {
        public int LengthOfLongestSubstring(string s)
        {
            HashSet<char> charSet = new();
            int left = 0, right = 0, maxLengt = 0;

            while (right < s.Length)
            {
                if (!charSet.Contains(s[right]))
                {
                    charSet.Add(s[right]);
                    right++;
                    maxLengt = Math.Max(maxLengt, charSet.Count);
                }
                else
                {
                    charSet.Remove(s[left]);
                    left++;
                }
            }
            return maxLengt;
        }
    }
}

//pwwkew 
//abcabcbb