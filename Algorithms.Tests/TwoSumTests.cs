using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Tasks;
using NUnit.Framework;

namespace Algorithms.Tests
{
    [TestFixture]
    public class TwoSumTests
    {
        [Test]
        public void TwoSumTests_FirstTest()
        {
            // Arrange
            var nums = new int[] {2, 7, 11, 15};
            var target = 9;
            var expected = new int[] {0, 1};

            // Act
            var actual = nums.GetIndicesOfTwoNumbers(target);

            // Assert
            Assert.IsTrue(actual.SequenceEqual(expected));
        }
    }
}
