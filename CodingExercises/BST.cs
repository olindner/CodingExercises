using System;
using System.Collections.Generic;

namespace CodingExercises
{
    public class BST
    {
        public static List<int> PreorderIterativeTraversal(TreeNode root)
        {
            List<int> list = new List<int>();
            if (root == null) return list;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                root = stack.Pop();
                list.Add(root.val);
                if (root.right != null) stack.Push(root.right);
                if (root.left != null) stack.Push(root.left);
            }
            return list;
        }

        public static List<int> PreorderRecursiveTraversal(TreeNode root)
        {
            List<int> list = new List<int>();
            if (root == null) return list;
            list.Add(root.val);
            list.AddRange(PreorderRecursiveTraversal(root.left));
            list.AddRange(PreorderRecursiveTraversal(root.right));
            return list;
        }

        public static List<int> InorderIterativeTraversal(TreeNode root)
        {
            List<int> list = new List<int>();
            if (root == null) return list;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            while (root != null || stack.Count > 0)
            {
                while (root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }
                root = stack.Pop();
                list.Add(root.val);
                root = root.right;
            }
            return list;
        }

        public static List<int> InorderRecursiveTraversal(TreeNode root)
        {
            List<int> list = new List<int>();
            if (root == null) return list;
            List<int> leftList = InorderIterativeTraversal(root.left);
            list.AddRange(leftList);
            list.Add(root.val);
            List<int> rightList = InorderIterativeTraversal(root.right);
            list.AddRange(rightList);
            return list;
        }

        public static List<int> PostorderIterativeTraversal(TreeNode root)
        {
            List<int> list = new List<int>();
            if (root == null) return list;
            Stack<TreeNode> stackOne = new Stack<TreeNode>();
            Stack<TreeNode> stackTwo = new Stack<TreeNode>();
            stackOne.Push(root);
            while (stackOne.Count > 0)
            {
                root = stackOne.Pop();
                stackTwo.Push(root);
                if (root.left != null) stackOne.Push(root.left);
                if (root.right != null) stackOne.Push(root.right);

            }
            while (stackTwo.Count > 0)
            {
                root = stackTwo.Pop();
                list.Add(root.val);
            }
            return list;
        }

        public static List<int> PostorderRecursiveTraversal(TreeNode root)
        {
            List<int> list = new List<int>();
            if (root == null) return list;
            List<int> leftList = PostorderRecursiveTraversal(root.left);
            list.AddRange(leftList);
            List<int> rightList = PostorderRecursiveTraversal(root.right);
            list.AddRange(rightList);
            list.Add(root.val);
            return list;
        }

        private static bool IsValidBSTHelper(TreeNode root, int min, int max)
        {
            if (root == null) return true;
            if (root.val <= min || root.val >= max) return false;
            return IsValidBSTHelper(root.left, min, Math.Min(max, root.val)) && IsValidBSTHelper(root.right, Math.Max(min, root.val), max);
        }

        public static bool IsValidBST(TreeNode root)
        {
            if (root == null) return true;
            return IsValidBSTHelper(root, int.MinValue, int.MaxValue);
        }
    }
}
