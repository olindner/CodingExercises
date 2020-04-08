namespace CodingExercises
{
    public class Strings
    {
        private static bool validWindow(int[] mapping, int k)
        {
            for (int i = 0; i < mapping.Length; ++i)
            {
                if (mapping[i] > 0) k--;
                if (k < 0) return false;
            }
            return true;
        }

        public static string LongestSubstringKUnique(string s, int k)
        {
            if (s == null || s.Length == 0) return "";
            int uniqueChars = 0;
            int[] mapping = new int[26];
            for (int i = 0; i < s.Length; ++i)
            {
                if (mapping[s[i] - 'a'] == 0) uniqueChars++;
                mapping[s[i] - 'a']++;
            }
            if (uniqueChars < k) return "";

            int curStart = 0, curEnd = 0, maxStart = 0, maxLength = 1;
            mapping = new int[26];
            mapping[s[0] - 'a']++;

            for (int i = 1; i < s.Length; ++i)
            {
                mapping[s[i] - 'a']++;
                curEnd++;

                while (!validWindow(mapping, k))
                {
                    mapping[s[curStart] - 'a']--;
                    curStart++;
                }

                if (curEnd - curStart + 1 > maxLength)
                {
                    maxStart = curStart;
                    maxLength = curEnd - curStart + 1;
                }
            }

            return s.Substring(maxStart, maxLength);
        }
    }
}
