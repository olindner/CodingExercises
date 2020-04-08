using Xunit;
using CodingExercises;

namespace CodingExercisesTests
{
    public class SubstringTests
    {
        [Theory]
        [InlineData(null, 1)]
        [InlineData("", 2)]
        [InlineData("aabbcc", 7)]
        public void LongestSubstringKUniqueFailureCases_ReturnEmptyString(string input, int k)
        {
            string result = Strings.LongestSubstringKUnique(input, k);

            Assert.Equal("", result);
        }

        [Theory]
        [InlineData("abbc", 1, "bb")]
        [InlineData("abbccddeddc", 2, "ddedd")]
        [InlineData("abcbbbbcccbdddadacb", 2, "bcbbbbcccb")]
        public void LongestSubstringKUnique_AnswerString(string wholeString, int k, string expectedSubstring)
        {
            string result = Strings.LongestSubstringKUnique(wholeString, k);

            Assert.Equal(expectedSubstring, result);
        }

        [Theory]
        [InlineData("aabbcc", 1, 2)]
        [InlineData("aabbcc", 2, 4)]
        [InlineData("aabbcc", 3, 6)]
        public void LongestSubstringKUnique_AnswerLength(string wholeString, int k, int expectedLength)
        {
            string result = Strings.LongestSubstringKUnique(wholeString, k);

            Assert.Equal(expectedLength, result.Length);
        }
    }
}