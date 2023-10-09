﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nick_white_leetcode;

public class MergeTwoBinaryTrees
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

    public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
    {
        if (root1 is null || root2 is null)
        {
            return root1 ?? root2;
        }

        root1.val += root2.val;

        root1.left = MergeTrees(root1.left, root2.left);
        root1.right = MergeTrees(root1.right, root2.right);

        return root1;
    }
}
