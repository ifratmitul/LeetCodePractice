namespace LeetCodePractice;
public class BST
{

    public TreeNode SearchBST(TreeNode root, int val)
    {

        if (root == null) return null;

        while (root != null && root.val != val)
        {
            root = val < root.val ? root.left : root.right;
        }

        return root;
    }

    public TreeNode deleteNode(TreeNode root, int n)
    {
        if (root == null) return root;

        while (root != null)
        {
            if (root.val < n) root = root.right;
            else if (root.val > n) root = root.left;
            else if(root.val == n)
            {
                // this block mea
                if (root.left == null) return root.left;
                if (root.right == null) return root.right;
            }

        }

        return root;

    }

}
