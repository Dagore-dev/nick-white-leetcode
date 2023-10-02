using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nick_white_leetcode;

public class NTreePreorderTraversal
{
    // Definition for a Node.
    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }
    public IList<int> Preorder(Node root)
    {
        if (root is null)
        {
            return Array.Empty<int>();
        }

        Stack<Node> stack = new();
        IList<int> output = new List<int>();

        stack.Push(root);
        while (stack.Count != 0)
        {
            root = stack.Pop();
            output.Add(root.val);

            for (int i = root.children.Count - 1; i > -1; i--)
            {
                stack.Push(root.children[i]);
            }
        }

        return output;
    }
}
