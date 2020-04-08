using System;

namespace CodingExercises
{
    public class SinglyLinkedList
    {
        public static Node Reverse(Node root)
        {
            if (root == null) return root;
            Node first = null, second = root, third = null;
            while (second != null)
            {
                third = second.next;
                second.next = first;
                first = second;
                second = third;
            }
            return first;
        }

        public static bool Cycle(Node root)
        {
            if (root == null || root.next == null) return false;
            Node fastPointer = root.next, slowPointer = root;
            while(fastPointer != null && slowPointer != null) {
                if (fastPointer == slowPointer) return true;
                if (fastPointer.next == null || fastPointer.next.next == null) return false;
                fastPointer = fastPointer.next.next;
                slowPointer = slowPointer.next;
            }
            return false;
        }

        public static Node Intersection(Node first, Node second)
        {
            if (first == null || second == null) return null;
            if (first == second) return first;

            int lengthFirst = 1, lengthSecond = 1;
            Node firstCounter = first, secondCounter = second;

            while (firstCounter != null)
            {
                lengthFirst++;
                firstCounter = firstCounter.next;
            }
            while (secondCounter != null)
            {
                lengthSecond++;
                secondCounter = secondCounter.next;
            }

            while (lengthFirst > lengthSecond)
            {
                first = first.next;
                lengthFirst--;
            }
            while (lengthSecond > lengthFirst)
            {
                second = second.next;
                lengthSecond--;
            }

            while (first != null && second != null)
            {
                if (first == second) return first;
                first = first.next;
                second = second.next;
            }

            return null;
        }
    }
}
