namespace LeetCode;
public class BasicProblems
{
    private readonly SearchAlgo? _searchAlgo;

    public BasicProblems(SearchAlgo searchAlgo)
    {
        _searchAlgo = searchAlgo;
    }


    public int RemoveDuplicates(int[] num)
    {
        int i, j = 0;

        for (i = 1; i < num.Length; i++)
        {
            if (num[i] != num[j])
            {
                num[++j] = num[i];
            }
        }

        return j + 1;
    }


    //SubArray
    public int MaxSubArray(int[] nums)
    {

        int maxSum = Int32.MinValue;
        int runningTotal = 0;
        foreach (int i in nums)
        {
            runningTotal += i;
            if (runningTotal > maxSum)
            {
                maxSum = runningTotal;
            }

            if (runningTotal < 0)
            {
                runningTotal = 0; //effectively resetting
            }
        }

        return maxSum;


    }

    public int getMaxProfit(int[] arr)
    {
        int profit = 0;

        return profit;

    }

    public void MoveZeros(int[] nums)
    {
        int pos = -1;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {

                pos = pos == -1 ? i : Math.Min(pos, i);
            }
            else
            {
                if (pos != -1)
                {
                    swap(nums, pos, i);
                    while (nums[pos] != 0) pos++;
                }
            }
        }
    }


    public static void swap(int[] nums, int a, int b)
    {
        int temp = nums[a];
        nums[a] = nums[b];
        nums[b] = temp;
    }

    public int isBadVersion(int n)
    {

        int start = 1;
        int end = n;

        while (start < end)
        {
            int mid = start + (end - start) / 2; //Binary search equation to minimize search time;

            if (!isGood(/*pass mid here*/))
            {

                start = mid + 1;

            }

            else
            {
                end = mid;
            }



        }

        return start;

    }

    public bool isGood()
    {
        //for dummy use
        return true;
    }

    public int[] findUniqueValues(int[] nums1, int[] nums2)
    {
        IList<int> data = new List<int>();
        Array.Sort(nums2);

        foreach (var item in nums1)
        {

            //Console.WriteLine(item + " ==> " + recursiveBinarySearch(nums2, 0, nums2.Length, item));
            if (recursiveBinarySearch(nums2, 0, nums2.Length, item))
            {
                data.Add(item);
            }

        }
        string s = JsonSerializer.Serialize(data);
        Console.WriteLine(s);


        return data.Distinct().ToArray();
    }

    public static bool recursiveBinarySearch(int[] arr, int start, int end, int n)
    {
        Array.Sort(arr);
        if (start >= end) return false;
        int mid = (start + end) / 2;
        if (arr[mid] == n) return true;
        else if (arr[mid] < n)
        {
            return recursiveBinarySearch(arr, mid + 1, end, n);
        }
        else
        {
            return recursiveBinarySearch(arr, start, mid, n);
        }
    }

    public int[] twoSum(int[] nums, int target)
    {
        int i = 0;
        Dictionary<int, int> res = new Dictionary<int, int>();

        while (i < nums.Length)
        {
            int sum = target - nums[i];
            if (res.ContainsKey(sum))
            {
                return new int[] { i, res[sum] };
            }

            if (!res.ContainsKey(nums[i])) res.Add(nums[i], i);

            i++;
        }
        return new int[] { 0, 0 };
    }

    public IList<IList<int>> ThreeSum(int[] nums)
    {
        IList<IList<int>> res = new List<IList<int>>();
        Array.Sort(nums);

        for (int i = 0; i + 2 < nums.Length; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }

            int j = i + 1;
            int k = nums.Length - 1;

            while (j < k)
            {
                int sum = nums[i] + nums[j] + nums[k];

                if (sum == 0)
                {
                    res.Add(new List<int> { nums[i], nums[j], nums[k] });
                    k--;

                    while (j < k && nums[k] == nums[k + 1]) k--;
                }
                else if (sum > 0)
                {
                    k--;

                }
                else
                {
                    j++;
                }
            }

        }

        return res;

    }


    public int[] PlusOne(int[] digits)
    {

        int n = digits.Length;
        int[] res = new int[n + 1];
        int carry = 0;
        digits[n - 1]++;

        for (int i = n - 1; i >= 0; i--)
        {
            digits[i] += carry;
            carry = 0;


            if (digits[i] > 9)
            {
                digits[i] = 0;
                carry = 1;
            }

            res[i + 1] = digits[i];

        }

        if (carry > 0)
        {
            res[0] = carry;
            return res;
        }



        return digits;
    }
    
    public int[] Intersect(int[] nums1, int[] nums2) {
        Array.Sort(nums1);
        Array.Sort(nums2);
        List<int> res = new List<int>();
        IDictionary<int, int> map = new Dictionary<int, int>();
        
        
        foreach (var item in nums1)
        {
            map.TryGetValue(item, out int freq);
            if (freq > 0)
            {
                map[item]++;
            }
            else
            {
                map.Add(item, 1);
                
            }
        }

        foreach (var item in nums2)
        {
            map.TryGetValue(item, out int freq);
            if (freq > 0)
            {
                res.Add(item);
            }
        }
        
        return res.ToArray();
    }
    
    public bool IsPerfectSquare(int num)
    {
        if (num == 1) return true;
        Int64 start = 0;
        Int64 end = num;

        while (start <= end)
        {
            Int64 mid = (start + end) / 2;
            if (mid * mid == num) return true;

            else if (mid * mid > num)
            {
                end = mid - 1;
            }
            else
            {
                start = mid + 1;
            }
        }

        return false;
    }
    
    public char NextGreatestLetter(char[] letters, char target)
    {
        int start = 0;
        int end = letters.Length - 1;
        while (start <= end)
        {

            int mid = start + (end - start) / 2;

            if (target <letters[mid])
            {
                end = mid - 1;
            }
            else
            {
                start = mid + 1;
            }
        }
        return letters[start % letters.Length];
    }

    public Boolean isPalindrom(int x)
    {
        int reverse = 0;
        int n = x;
        while (n != 0)
        {
            int lastDigit = n % 10;
            reverse = (reverse * 10) + lastDigit;
            n = n / 10;
        }

        if (x == reverse) return true;
        return false;
    }
    
    public void ReverseString(char[] s)
    {

        int i = 0;
        int j = s.Length - 1;
        while (i <= j)
        {
            (s[i], s[j]) = (s[j], s[i]);
            i++;
            j--;
        }
        

    }
    
    public int Reverse(int x)
    {
        Int32 rev = 0;
        Int32 n = x;
        while (n != 0)
        {
            int lastDigit = n % 10;
            n = n / 10;
            if (rev > Int32.MaxValue/10 || (rev == Int32.MaxValue / 10 && lastDigit > 7)) return 0;
            if (rev < Int32.MinValue/10 || (rev == Int32.MinValue/ 10 && lastDigit < -8)) return 0;
            rev = (rev * 10) + lastDigit;

        }
        
        return rev;
    }
    
    public int LastStoneWeight(int[] stones)
    {
        PriorityQueue<int, int> queue = new PriorityQueue<int, int>(stones.Select(s=>(s,s)), new Comparer());

        while (queue.Count >= 2)
        {
            var y = queue.Dequeue();
            var x = queue.Dequeue();
            if (x != y)
            {
                queue.Enqueue(y-x, y-x);
                
            }
        }

        if (queue.Count == 1) return queue.Dequeue();
     
        

        return 0;

    }
    public class Comparer: IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if (x < y) return 1;
            else if (x == y) return 0;
            else return -1;
        }
    }
    
}
