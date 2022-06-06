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
    public class RomanToIntegerTests
    {
        [TestCase("III", ExpectedResult = 3)]
        [TestCase("LVIII", ExpectedResult = 58)]
        [TestCase("MCMXCIV", ExpectedResult = 1994)]
        public int RomanToInt(string romanString)
        {
            return romanString.RomanToInt();
        }
    }
}
