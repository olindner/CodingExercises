using Xunit;
using CodingExercises;

namespace CodingExercisesTests
{
    public class ReverseSinglyLinkedListTests
    {
        [Fact]
        public void TestNullNodeReverse_ReturnsNullNode()
        {
            Node nullNode = null;

            Node result = SinglyLinkedList.Reverse(nullNode);

            Assert.True(TestHelpers.TwoSinglyLinkedListsAreTheSame(nullNode, result));
        }

        [Fact]
        public void TestOneNodeReverse_ReturnsSameNode()
        {
            Node single = new Node(1);

            Node result = SinglyLinkedList.Reverse(single);

            Assert.True(TestHelpers.TwoSinglyLinkedListsAreTheSame(single, result));
        }

        [Fact]
        public void TestBasicReverse()
        {
            Node input = new Node(1, new Node(2, new Node(3)));
            Node expectedResult = new Node(3, new Node(2, new Node(1)));

            Node result = SinglyLinkedList.Reverse(input);

            Assert.True(TestHelpers.TwoSinglyLinkedListsAreTheSame(expectedResult, result));
        }
    }
}