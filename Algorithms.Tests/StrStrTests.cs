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
    public class StrStrTests
    {
        [Test]
        [TestCase("hello", "ll", ExpectedResult = 2)]
        [TestCase("aaaaa", "bba", ExpectedResult = -1)]
        [TestCase("cwertycar", "car", ExpectedResult = 6)]
        [TestCase("cardboard", "car", ExpectedResult = 0)]
        [TestCase("waterflow", "fl", ExpectedResult = 5)]
        [TestCase("flow", "w", ExpectedResult = 3)]
        [TestCase("aaa", "", ExpectedResult = 0)]
        [TestCase("mississippi", "issip", ExpectedResult = 4)]
        public int Intersect_ReturnsIndexOfIntersection(string haystack, string needle)
        {
            return haystack.IntersectWith(needle);
        }
    }
}
