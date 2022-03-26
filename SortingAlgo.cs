namespace LeetCode;

public class SortingAlgo
{

    public int[] BubbleSort(int[] arr)
    {
        for (int lastUnsortedIndex = arr.Length -1; lastUnsortedIndex > 0;  lastUnsortedIndex--)
        {
            for (int i = 0; i < lastUnsortedIndex; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    SwapTool(arr, i, i+1);
                }
            }
        }
        return arr;
    }

    private static void SwapTool(int[] arr, int i, int j)
    {
        if (i == j) return;
        (arr[i], arr[j]) = (arr[j], arr[i]); //Swapping value of arr[i] with arr[j]
    }
    
}