using System.Collections;
using System.Net.Mail;
namespace LeetCode;
public class BasicProblems
{
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
        int k = nums.Length - 1;
        int i = 0, j = 1;

        while (i < nums.Length)
        {
            while (k > j)
            {

                int sum = nums[i] + nums[j] + nums[k];
                if (sum == 0)
                {

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
            i++;
        }

        return res;

    }
}
