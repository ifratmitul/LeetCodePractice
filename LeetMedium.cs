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

}
