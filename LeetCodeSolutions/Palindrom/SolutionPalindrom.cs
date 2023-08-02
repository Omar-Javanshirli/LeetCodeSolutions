using System.Linq;

namespace LeetCodeSolutions.Palindrom
{
    public class SolutionPalindrom
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0))
                return false;

            return IsPalindromeRecursive(x, 0);
        }

        public bool IsPalindromeRecursive(int remaining, int reversed)
        {
            if (remaining == 0)
                return reversed == remaining;

            int lastDigit = remaining % 10;
            reversed = reversed * 10 + lastDigit;

            return IsPalindromeRecursive(remaining / 10, reversed);
        }


        public bool IsPalindrome(string s)
        {
            string temp = string.Empty;
            var result = s.Replace(" ", "").ToLower();
            result = result.Replace(",", "");
            result = result.Replace(":", "");

            var clean = s.ToLower().Where(x => char.IsLetterOrDigit(x));

            int i = result.Length - 1;

            while (i >= 0)
                temp += result[i--];

            if (result != temp.ToLower())
                return false;

            return true;
        }
    }
}
