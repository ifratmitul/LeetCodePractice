namespace LeetCodePractice
{
    public class TwoPointer
    {
        public static bool IsPalindrom(string s)
        {
            int sp = 0;
            int i = 0;
            char[] arr = s.ToCharArray().Where(item => Char.IsLetterOrDigit(item)).ToArray();
            int ep = arr.Length - 1;

            while (i < arr.Length && ep > sp)
            {
                if (Char.ToLower(arr[sp]) != Char.ToLower(arr[ep])) return false;
                i++;
                sp++;
                ep--;

            }

            return true;
        }

        public static int[] TwoSum(int[] numbers, int target)
        {
            int start = 0;
            int end = numbers.Length - 1;

            while (start <= end)
            {
                if (numbers[start] + numbers[end] > target)
                {
                    end--;
                }
                else if (numbers[start] + numbers[end] < target)
                {
                    start++;

                }
                else
                {
                    return new int[] { start + 1, end + 1 };
                }
            }

            return new int[] { -1, -1 };
        }
    }
}