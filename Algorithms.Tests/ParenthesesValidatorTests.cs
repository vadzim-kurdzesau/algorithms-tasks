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
    public class ParenthesesValidatorTests
    {
        [TestCase("()", ExpectedResult = true)]
        [TestCase("()[]{}", ExpectedResult = true)]
        [TestCase("(]", ExpectedResult = false)]
        public bool IsValid(string str)
        {
            return ParenthesesValidator.IsValid(str);
        }
    }
}
