using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Tasks;
using NUnit.Framework;

namespace Algorithms.Tests.Medium
{
    [TestFixture]
    public class LongestSubstringTests
    {
        [Test]
        [TestCase("abcabcbb", ExpectedResult = 3)]
        [TestCase("bbbbb", ExpectedResult = 1)]
        [TestCase("pwwkew", ExpectedResult = 3)]
        [TestCase("", ExpectedResult = 0)]
        [TestCase("a", ExpectedResult = 1)]
        [TestCase("abcadb", ExpectedResult = 4)]
        [TestCase("abcadbe", ExpectedResult = 5)]
        public int LengthOfLongestSubstring_ReturnsLengthOfSubstring(string str)
        {
            return str.LengthOfLongestSubstring();
        }
    }
}
