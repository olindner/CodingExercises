using Xunit;
using System.Collections.Generic;
using CodingExercises;

namespace CodingExercisesTests
{
    public class IntersectingListsTests
    {
        [Fact]
        public void TestNullCases_ReturnNull()
        {
            Node nullNode = null, validNode = new Node(1), otherValidNode = new Node(2);
            Node resultFirstNull = SinglyLinkedList.Intersection(nullNode, validNode);
            Node resultBNull = SinglyLinkedList.Intersection(validNode, nullNode);
            Node resultNoIntersection = SinglyLinkedList.Intersection(validNode, otherValidNode);

            Assert.Null(resultFirstNull);
            Assert.Null(resultBNull);
            Assert.Null(resultNoIntersection);
        }

        [Fact]
        public void TestBasicIntersections_ReturnCorrectNode()
        {
            Node A = new Node(10);
            Node B = A;

            Node result = SinglyLinkedList.Intersection(A, B);

            Assert.Equal(A, result);
        }

        [Fact]
        public void TestIntersection_ReturnsCorrectNode()
        {
            Node A = new Node(10, new List<int>() { 3, 78, 3, -1, 87, 3 });
            Node B = new Node(6, new List<int>() { 5, 8 });
            Node endOfBNode = B.next.next, middleNodeOfA = A.next.next.next;
            endOfBNode.next = middleNodeOfA;

            Node result = SinglyLinkedList.Intersection(A, B);

            Assert.Equal(middleNodeOfA, result);
        }
    }
}