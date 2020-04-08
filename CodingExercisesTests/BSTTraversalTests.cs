using Xunit;
using System.Collections.Generic;
using CodingExercises;

namespace CodingExercisesTests
{
    public class BSTTraversalTests
    {
        [Fact]
        public void TestPreorderIterativeNullRoot_ReturnsEmptyList()
        {
            TreeNode nullTreeNode = null;

            List<int> emptyList = BST.PreorderIterativeTraversal(nullTreeNode);

            Assert.Empty(emptyList);
        }

        [Fact]
        public void TestPreorderIterative_ReturnsCorrectAnswer()
        {
            TreeNode root = new TreeNode(5, new TreeNode(2, new TreeNode(1), new TreeNode(3, null, new TreeNode(4))), new TreeNode(6, null, new TreeNode(8, new TreeNode(7), null)));
            List<int> expectedList = new List<int>() { 5, 2, 1, 3, 4, 6, 8, 7 };

            List<int> list = BST.PreorderIterativeTraversal(root);

            Assert.Equal(expectedList, list);
        }

        [Fact]
        public void TestPreorderRecursiveNullRoot_ReturnsEmptyList()
        {
            TreeNode nullTreeNode = null;

            List<int> emptyList = BST.PreorderRecursiveTraversal(nullTreeNode);

            Assert.Empty(emptyList);
        }

        [Fact]
        public void TestPreorderRecursive_ReturnsCorrectAnswer()
        {
            TreeNode root = new TreeNode(5, new TreeNode(2, new TreeNode(1), new TreeNode(3, null, new TreeNode(4))), new TreeNode(6, null, new TreeNode(8, new TreeNode(7), null)));
            List<int> expectedList = new List<int>() { 5, 2, 1, 3, 4, 6, 8, 7 };

            List<int> list = BST.PreorderRecursiveTraversal(root);

            Assert.Equal(expectedList, list);
        }

        [Fact]
        public void TestInorderIterativeNullRoot_ReturnsEmptyList()
        {
            TreeNode nullTreeNode = null;

            List<int> emptyList = BST.InorderIterativeTraversal(nullTreeNode);

            Assert.Empty(emptyList);
        }

        [Fact]
        public void TestInorderIterative_ReturnsCorrectOrder()
        {
            TreeNode left = new TreeNode(1);
            TreeNode right = new TreeNode(3);
            TreeNode root = new TreeNode(2, left, right);
            List<int> expectedResult = new List<int> { 1, 2, 3 };

            List<int> result = BST.InorderIterativeTraversal(root);

            Assert.Equal(3, result.Count);
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void TestInorderIterativeLarger_ReturnsCorrectOrder()
        {
            TreeNode root = new TreeNode(7, new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(5, null, new TreeNode(6))), new TreeNode(10, new TreeNode(8, null, new TreeNode(9)), null));
            List<int> expectedResult = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<int> result = BST.InorderIterativeTraversal(root);

            Assert.Equal(10, result.Count);
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void TestInorderRecursiveNullRoot_ReturnsEmptyList()
        {
            TreeNode nullTreeNode = null;

            List<int> emptyList = BST.InorderRecursiveTraversal(nullTreeNode);

            Assert.Empty(emptyList);
        }

        [Fact]
        public void TestInorderRecursive_ReturnsCorrectOrder()
        {
            TreeNode left = new TreeNode(1);
            TreeNode right = new TreeNode(3);
            TreeNode root = new TreeNode(2, left, right);
            List<int> expectedResult = new List<int> { 1, 2, 3 };

            List<int> result = BST.InorderRecursiveTraversal(root);

            Assert.Equal(3, result.Count);
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void TestInorderRecusiveLarger_ReturnsCorrectOrder()
        {
            TreeNode root = new TreeNode(7, new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(5, null, new TreeNode(6))), new TreeNode(10, new TreeNode(8, null, new TreeNode(9)), null));
            List<int> expectedResult = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<int> result = BST.InorderRecursiveTraversal(root);

            Assert.Equal(10, result.Count);
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void TestPostorderIterativeNullRoot_ReturnsEmptyList()
        {
            TreeNode nullTreeNode = null;

            List<int> emptyList = BST.PostorderIterativeTraversal(nullTreeNode);

            Assert.Empty(emptyList);
        }

        [Fact]
        public void TestPostorderIterative_ReturnsCorrectAnswer()
        {
            TreeNode root = new TreeNode(5, new TreeNode(2, new TreeNode(1), new TreeNode(3, null, new TreeNode(4))), new TreeNode(6, null, new TreeNode(8, new TreeNode(7), null)));
            List<int> expectedList = new List<int>() { 1, 4, 3, 2, 7, 8, 6, 5 };

            List<int> list = BST.PostorderIterativeTraversal(root);

            Assert.Equal(expectedList, list);
        }

        [Fact]
        public void TestPostorderRecursiveNullRoot_ReturnsEmptyList()
        {
            TreeNode nullTreeNode = null;

            List<int> emptyList = BST.PostorderRecursiveTraversal(nullTreeNode);

            Assert.Empty(emptyList);
        }

        [Fact]
        public void TestPostorderRecursive_ReturnsCorrectAnswer()
        {
            TreeNode root = new TreeNode(5, new TreeNode(2, new TreeNode(1), new TreeNode(3, null, new TreeNode(4))), new TreeNode(6, null, new TreeNode(8, new TreeNode(7), null)));
            List<int> expectedList = new List<int>() { 1, 4, 3, 2, 7, 8, 6, 5 };

            List<int> list = BST.PostorderRecursiveTraversal(root);

            Assert.Equal(expectedList, list);
        }
    }
}