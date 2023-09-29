using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace nick_white_leetcode;

public class NTreePostorderTraversal
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

    public IList<int> Postorder(Node root)
    {
        if (root is null)
            return Array.Empty<int>();

        Node node = null;
        Stack<Node> stack = new();
        stack.Push(root);

        Stack<int> result = new();

        while (stack.Count != 0)
        {
            node = stack.Pop();
            result.Push(node.val);

            for (int i = 0; i < node.children.Count; i++)
            {
                stack.Push(node.children[i]);
            }
        }

        return result.ToArray();
    }
}
