namespace LeetCodeSolutions.Pow
{
    public class SolutionPow
    {
        public double MyPow(double x, int n)
        {
            if (n < 0) { x = 1 / x; }
            return RecPow(x, n);
        }

        private double RecPow(double x, int n)
        {
            if (n == 0) return 1;
            if (n == 1 || n == -1) return x;

            double res = RecPow(x, n / 2);
            return res * res * (n % 2 == 0 ? 1 : x);
        }
    }
}
