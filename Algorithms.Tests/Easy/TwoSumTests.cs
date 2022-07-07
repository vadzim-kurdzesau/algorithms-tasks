using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Tasks;
using NUnit.Framework;

namespace Algorithms.Tests.Easy
{
    [TestFixture]
    public class TwoSumTests
    {
        [Test]
        public void GetIndicesOfTwoNumbers_FirstTest()
        {
            // Arrange
            var nums = new int[] {2, 7, 11, 15};
            var target = 9;
            var expected = (0, 1);

            // Act
            var actual = nums.GetIndicesOfTwoNumbers(target);

            // Assert
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void GetIndicesOfTwoNumbers_SecondTest()
        {
            // Arrange
            var nums = new int[] { 3, 2, 4 };
            var target = 6;
            var expected = (1, 2);

            // Act
            var actual = nums.GetIndicesOfTwoNumbers(target);

            // Assert
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void GetIndicesOfTwoNumbers_ThirdTest()
        {
            // Arrange
            var nums = new int[] { 3, 3 };
            var target = 6;
            var expected = (0, 1);

            // Act
            var actual = nums.GetIndicesOfTwoNumbers(target);

            // Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
