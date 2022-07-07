using Algorithms.Tasks;
using NUnit.Framework;

namespace Algorithms.Tests.Easy
{
    [TestFixture]
    public class RemoveDuplicatesTests
    {
        public static object[] TestCases => new object[]
        {
            new object[] { new int[] { 1, 1, 2 }, new int[] { 1, 2 }, 2 },
            new object[] { new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, new int[] { 0, 1, 2, 3, 4 }, 5 },
            new object[] { new int[] { 1 }, new int[] { 1 }, 1 },
        };

        [Test]
        [TestCaseSource(nameof(TestCases))]
        public void RemoveDuplicates_RemovesDuplicatesAndReturnsExpectedK(int[] nums, int[] expectedArray, int expectedK)
        {
            // Act
            var actualK = nums.RemoveDuplicates();

            // Assert
            Assert.AreEqual(expectedK, actualK);
            AssertAreEqual(expectedArray, nums, actualK);
        }

        private static void AssertAreEqual(int[] expected, int[] actual, int k)
        {
            for (int i = 0; i < k; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
