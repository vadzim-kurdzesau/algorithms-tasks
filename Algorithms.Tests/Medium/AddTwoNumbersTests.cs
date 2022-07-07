using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Tasks;
using Algorithms.Tests.Utils;
using NUnit.Framework;

namespace Algorithms.Tests.Medium
{
    [TestFixture]
    public class AddTwoNumbersTests
    {
        [Test]
        public void Add_ReturnsSum()
        {
            // Arrange
            var firstList = new ListNode(2) { Next = new ListNode(4) { Next = new ListNode(3) } };
            var secondList = new ListNode(5) { Next = new ListNode(6) { Next = new ListNode(4) } };
            var expected = new ListNode(7)
            {
                Next = new ListNode(0)
                {
                    Next = new ListNode(8)
                }
            };

            // Act
            var actual = firstList.Add(secondList);

            // Assert
            Assert.IsTrue(AssertWrapper.AreEqual(expected, actual));
        }

        [Test]
        public void Add_ReturnsSum_SecondTest()
        {
            // Arrange
            var firstList = new ListNode(0);
            var secondList = new ListNode(0);
            var expected = new ListNode(0);

            // Act
            var actual = firstList.Add(secondList);

            // Assert
            Assert.IsTrue(AssertWrapper.AreEqual(expected, actual));
        }

        [Test]
        public void Add_ReturnsSum_ThirdTest()
        {
            // Arrange
            var firstList = new ListNode(9) { Next = new ListNode(9) { Next = new ListNode(9) { Next = new ListNode(9) { Next = new ListNode(9) { Next = new ListNode(9) { Next = new ListNode(9) } } } } } };
            var secondList = new ListNode(9) { Next = new ListNode(9) { Next = new ListNode(9) { Next = new ListNode(9) } } };
            var expected = new ListNode(8)
            {
                Next = new ListNode(9)
                {
                    Next = new ListNode(9)
                    {
                        Next = new ListNode(9)
                        {
                            Next = new ListNode(0)
                            {
                                Next = new ListNode(0)
                                {
                                    Next = new ListNode(0)
                                    {
                                        Next = new ListNode(1)
                                    }
                                }
                            }
                        }
                    }
                }
            };

            // Act
            var actual = firstList.Add(secondList);

            // Assert
            Assert.IsTrue(AssertWrapper.AreEqual(expected, actual));
        }
    }
}
