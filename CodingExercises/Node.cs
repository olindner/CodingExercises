using System.Collections.Generic;

namespace CodingExercises
{
    public class Node
    {
        public int val { get; }
        public Node next { get; set; }
        public Node(int valIn)
        {
            val = valIn;
            next = null;
        }
        public Node(int valIn, Node nodeIn)
        {
            val = valIn;
            next = nodeIn;
        }
        public Node(int valIn, List<int> nextVals)
        {
            val = valIn;
            next = new Node(nextVals[0]);
            Node nextNode = next;
            for (int i = 1; i < nextVals.Count; i++)
            {
                Node newNode = new Node(nextVals[i]);
                nextNode.next = newNode;
                nextNode = nextNode.next;
            }
        }
    }
}
