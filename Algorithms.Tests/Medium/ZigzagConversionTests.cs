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
    public class ZigzagConversionTests
    {
        [Test]
        [TestCase("PAYPALISHIRING", 3, ExpectedResult = "PAHNAPLSIIGYIR")]
        [TestCase("PAYPALISHIRING", 4, ExpectedResult = "PINALSIGYAHRPI")]
        [TestCase("A", 1, ExpectedResult = "A")]
        public string Convert_ReturnsConvertedString(string str, int numberOfRows)
        {
            return str.Convert(numberOfRows);
        }
    }
}
