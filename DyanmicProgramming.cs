namespace LeetCodePractice
{
    public class DynamicProgramming
    {
        public static Int64 Fib(int n, Dictionary<int, Int64> D = null)
        {
            if (D == null)
            {
                D = new Dictionary<int, Int64>();
            }
            if (D != null && D.ContainsKey(n))
            {
                return D[n];
            }
            if (n <= 2) return 1;
            
            D.Add(n, Fib(n - 1, D) + Fib(n - 2, D));

            return D[n];
        }


        public static Int64 AnotherFibDp(int n)
        {
            Int64[] f = new Int64[n + 2];
            int i;
            f[0] = 0;
            f[1] = 1;

            for (i = 2; i <= n; i++)
            {
                f[i] = f[i - 1] + f[i - 2];
            }
            return f[n];
        }
    }
}