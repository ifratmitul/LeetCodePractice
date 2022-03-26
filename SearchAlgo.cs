namespace LeetCode;

public class SearchAlgo
{

    public static int BinarySearch(int[] arr, int val)
    {
        int start = 0;
        int end = arr.Length;

        while (start < end)
        {
            int mid = (start + end) / 2;
            if (arr[mid] == val)
            {
                return mid;
            }
            else if (arr[mid] < val)
            {
                start = mid + 1;
            }
            else
            {
                end = mid;
            }
        }

        return -1;

    }


    public int RecursiveBinarySearch(int[] arr, int val)
    {
        return RecursiveBinarySearch(arr, 0, arr.Length, val);
    }

    private int RecursiveBinarySearch(int[] arr, int start, int end, int val)
    {
        if (start >= end)
        {
            return -1;
        }

        int mid = (start + end) / 2;

        if (arr[mid] == val) return mid;
        else if (arr[mid] < val) return RecursiveBinarySearch(arr, mid + 1, end, val);
        else return RecursiveBinarySearch(arr, 0, mid, val);

    }

}
