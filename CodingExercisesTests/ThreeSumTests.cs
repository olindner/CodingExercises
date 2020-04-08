using Xunit;
using System.Collections.Generic;
using CodingExercises;

namespace CodingExercisesTests
{
    public class ThreeSumTests {

        public static IEnumerable<object[]> TestingData =>
        new List<object[]>
        {
            new object[] { null, null },
        };

        [Theory]
        [MemberData(nameof(TestingData))]
        public void TestNullCases(List<int> list, HashSet<int> expected) {
            HashSet<int> result = Lists.ThreeSum(list);

            Assert.Equal(expected, result);
        }
    }
}