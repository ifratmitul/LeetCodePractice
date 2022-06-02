namespace LeetCodePractice;
public class LeetMedium
{
    int sum = 0;
    public TreeNode ConvertBST(TreeNode root)
    {
        TreeNode newTree = root;

        if (root.right != null) ConvertBST(root.right);
        sum = sum + root.val;
        newTree.val = sum;
        if (root.left != null) ConvertBST(root.left);

        return newTree;
    }
    List<int> res = new List<int>();
    public int KthSmallest(TreeNode root, int k)
    {

        if (root == null) return 0;

        if (root.left != null) KthSmallest(root.left, k);
        res.Add(root.val);
        if (root.right != null) KthSmallest(root.right, k);

        return res[k <= 0 ? k : k - 1];

    }

    public int[] TopKFrequent(int[] nums, int k)
    {

        if (nums.Length <= 1) return nums;

        Dictionary<int, int> myMap = new Dictionary<int, int>();
        int[] arr = new int[k];

        for (int i = 0; i < nums.Length; i++)
        {
            int count;
            if (myMap.TryGetValue(nums[i], out count))
            {
                myMap[nums[i]] = ++count;
            }
            else
            {
                myMap[nums[i]] = 1;
            }

        }
        int l = 0;

        foreach (KeyValuePair<int, int> item in myMap.OrderByDescending(key => key.Value))
        {
            if (l >= k) break;
            arr[l] = item.Key;
            ++l;
        }

        return arr;
    }

     public int[] ProductExceptSelf(int[] nums) {
        int[] res  = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++)
        {
            var product = nums.Where((n,index)=> index != i).ToArray();

            int p = 1;
            if(nums[i] == 0) p = 0;

            for(int j = 0; j < product.Length; j++) {
                p = p * product[j];
            }
            res[i] = p;
        }
        return res;
    }

     public IList<IList<string>> GroupAnagram(string[] strs)
     {

          IList<IList<string>> res = new List<IList<string>>();
          Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

          foreach (string s in strs)
          {
               Console.WriteLine("Array Str => " + s);
               var sortedStr = String.Concat(s.OrderBy(c => c));
               Console.WriteLine(sortedStr);
               if (dict.ContainsKey(sortedStr)) dict[sortedStr].Add(s);
               else dict.Add(sortedStr, new List<string>() { s });
          }

          foreach (var item in dict)
          {
               res.Add(item.Value);
          }

          return res;
     }
     /*

           [["8","3",".",".","7",".",".",".","."]
          ,["6",".",".","1","9","5",".",".","."]
          ,[".","9","8",".",".",".",".","6","."]
          ,["8",".",".",".","6",".",".",".","3"]
          ,["4",".",".","8",".","3",".",".","1"]
          ,["7",".",".",".","2",".",".",".","6"]
          ,[".","6",".",".",".",".","2","8","."]
          ,[".",".",".","4","1","9",".",".","5"]
          ,[".",".",".",".","8",".",".","7","9"]]

     */
     public bool IsValidSudoku(char[][] board)
     {
          bool col = false, row = false, grid = false;

          for (int r = 0; r < board.Length; r++)
          {
               for (int c = 0; c < board[r].Length; c++)
               {
                    Console.WriteLine("Row {0}", board[r][c]);
               }
          }


          return col && row && grid;

     }

}


public class NestedIterator
{

    IList<NestedInteger> data = new List<NestedInteger>();
    Queue<int> myStack = new();

    public NestedIterator(IList<NestedInteger> nestedList)
    {
        foreach (var item in nestedList)
        {
            iterator(item);
        }
    }

    public bool HasNext()
    {
        return myStack.Count > 0;
    }

    public int Next()
    {
        return myStack.Dequeue();
    }

    private void iterator(NestedInteger nested)
    {
        if (nested.IsInteger())
        {
            myStack.Enqueue(nested.GetInteger());
        }
        else
        {
            IList<NestedInteger> nestedData = nested.GetList();
            foreach (NestedInteger item in nestedData)
            {
                iterator(item);
            }

        }
    }

}