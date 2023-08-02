using LeetCodeSolutions.BestTimeToBuyAndSellStock;
using LeetCodeSolutions.ContainsDublicate;
using LeetCodeSolutions.LongestSubstringWithoutRepating;
using LeetCodeSolutions.MargeSortedArray;
using LeetCodeSolutions.Palindrom;
using LeetCodeSolutions.Pow;
using LeetCodeSolutions.ThreeSum;
using LeetCodeSolutions.ValidParanheses;
using System;

namespace LeetCodeSolutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ar = new int[] { -1, 0, 0, 3, 3, 3, 0, 0, 0 };
            int[] ar2 = new int[] { 1, 2, 2 };
            var solution = new SolutionPalindrom();

            Console.WriteLine(solution.IsPalindrome("A man, a plan, a canal: Panama"));

        }
    }
}