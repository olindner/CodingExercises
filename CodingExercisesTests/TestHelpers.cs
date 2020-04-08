using CodingExercises;

namespace CodingExercisesTests
{
    public class TestHelpers
    {
        public static bool TwoSinglyLinkedListsAreTheSame(Node a, Node b)
        {
            if (a == null && b == null) return true;
            while (a != null && b != null)
            {
                if (a.val != b.val) return false;
                a = a.next;
                b = b.next;
            }
            if (a != null || b != null) return false;
            return true;
        }
    }
}