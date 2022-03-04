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
        return true;
    }

}
