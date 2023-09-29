using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static nick_white_leetcode.NTreePostorderTraversal;

namespace nick_white_leetcode;

public class BinaryTreeInorderTraversal
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public IList<int> InorderTraversal(TreeNode root)
    {
        if (root is null)
        {
            return Array.Empty<int>();
        }

        Stack<TreeNode> stack = new();
        IList<int> result = new List<int>();

        TreeNode current = root;

        while (current is not null || stack.Count != 0)
        {
            while (current is not null)
            {
                stack.Push(current);
                current = current.left;
            }

            current = stack.Pop();
            result.Add(current.val);

            current = current.right;
        }

        return result;
    }
}
