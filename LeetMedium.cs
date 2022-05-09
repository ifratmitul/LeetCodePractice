using System.Collections;
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