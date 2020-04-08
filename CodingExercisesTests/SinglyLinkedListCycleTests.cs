using Xunit;
using System.Collections.Generic;
using CodingExercises;

namespace CodingExercisesTests
{
    public class SinglyLinkedListCycleTests {

        [Fact]
        public void TestNullNode_ReturnsFalse() {
            Node nullNode = null;

            bool result = SinglyLinkedList.Cycle(nullNode);

            Assert.False(result);
        } 
        
        [Fact]
        public void TestSingleNode_ReturnsFalse() {
            Node singleNode = new Node(10);

            bool result = SinglyLinkedList.Cycle(singleNode);

            Assert.False(result);
        } 

        [Fact]
        public void TestBasicCycle_ReturnsTrue() {
            Node cycleNode = new Node(10, new List<int>() {5, 7});
            cycleNode.next.next.next = cycleNode;

            bool result = SinglyLinkedList.Cycle(cycleNode);

            Assert.True(result);
        } 
        
        [Fact]
        public void TestMidpointCycle_ReturnsTrue() {
            Node cycleNode = new Node(10, new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9});
            cycleNode.next.next.next.next.next.next.next.next.next.next = cycleNode.next.next.next.next;

            bool result = SinglyLinkedList.Cycle(cycleNode);

            Assert.True(result);
        } 
        
        [Fact]
        public void TestLongCycle_ReturnsTrue() {
            Node cycleNode = new Node(10, new List<int>() {
                1, 2, 3, 4, 5, 6, 7, 8, 9,
                1, 2, 3, 4, 5, 6, 7, 8, 9,
                1, 2, 3, 4, 5, 6, 7, 8, 9,
                1, 2, 3, 4, 5, 6, 7, 8, 9,
                1, 2, 3, 4, 5, 6, 7, 8, 9,
                1, 2, 3, 4, 5, 6, 7, 8, 9,
                1, 2, 3, 4, 5, 6, 7, 8, 9,
                1, 2, 3, 4, 5, 6, 7, 8, 9,
                1, 2, 3, 4, 5, 6, 7, 8, 9,
                1, 2, 3, 4, 5, 6, 7, 8, 9,
                1, 2, 3, 4, 5, 6, 7, 8, 9
                });
            Node endNode = cycleNode;
            while(endNode.next != null) {
                endNode = endNode.next;
            }
            endNode.next = cycleNode;

            bool result = SinglyLinkedList.Cycle(cycleNode);

            Assert.True(result);
        } 
    }
}