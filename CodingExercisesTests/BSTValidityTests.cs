using Xunit;
using System.Collections.Generic;
using CodingExercises;

namespace CodingExercisesTests
{
    public class BSTValidityTests
    {
        public static IEnumerable<object[]> TestingData =>
        new List<object[]>
        {
            new object[] { null, true },
            new object[] { new TreeNode(1), true },
            new object[] { new TreeNode(1, new TreeNode(3), null), false },
            new object[] { new TreeNode(2, new TreeNode(1), new TreeNode(3)), true },
            new object[] { new TreeNode(5, new TreeNode(4, new TreeNode(3, new TreeNode(2, new TreeNode(10), null), null), null), null), false },
            new object[] { new TreeNode(new TreeNode(1), 1, new TreeNode(1)), false },
            new object[] { new TreeNode(new TreeNode(1, 2, new TreeNode(3, new TreeNode(4))), 5, new TreeNode(6, new TreeNode(new TreeNode(7), 8))), true },
            new object[] { new TreeNode(new TreeNode(3, 7, 8), 10, new TreeNode(9, 15, 17)), false },
            new object[] { new TreeNode(new TreeNode(3, 7, 8), 10, new TreeNode(12, 15, 17)), true },
        };

        [Theory]
        [MemberData(nameof(TestingData))]
        public void TestBinaryTreeIsBST(TreeNode root, bool valid)
        {
            Assert.Equal(valid, BST.IsValidBST(root));
        }
    }
}