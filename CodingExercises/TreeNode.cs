using System;

namespace CodingExercises
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int valIn)
        {
            val = valIn;
            left = null;
            right = null;
        }
        public TreeNode(int valIn, TreeNode leftIn, TreeNode rightIn)
        {
            val = valIn;
            left = leftIn;
            right = rightIn;
        }
        public TreeNode(TreeNode leftIn, int valIn, TreeNode rightIn)
        {
            val = valIn;
            left = leftIn;
            right = rightIn;
        }
        public TreeNode(int leftIn, int valIn, int rightIn)
        {
            val = valIn;
            left = new TreeNode(leftIn);
            right = new TreeNode(rightIn);
        }
        public TreeNode(TreeNode leftIn, int valIn, int rightIn)
        {
            val = valIn;
            left = leftIn;
            right = new TreeNode(rightIn);
        }
        public TreeNode(int leftIn, int valIn, TreeNode rightIn)
        {
            val = valIn;
            left = new TreeNode(leftIn);
            right = rightIn;
        }
        public TreeNode(TreeNode leftIn, int valIn)
        {
            val = valIn;
            left = leftIn;
            right = null;
        }
        public TreeNode(int valIn, TreeNode rightIn)
        {
            val = valIn;
            left = null;
            right = rightIn;
        }
    }
}
