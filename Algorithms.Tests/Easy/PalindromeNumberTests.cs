using Algorithms.Tasks;
using NUnit.Framework;

namespace Algorithms.Tests;

[TestFixture]
public class PalindromeNumberTests
{
    [Test]
    public void IsPalindrome_NumberIsPalindrome()
    {
        // Arrange
        var number = 121;

        // Act
        bool result = number.IsPalindrome();

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void IsPalindrome_NumberIsNegative_NumberIsNotPalindrome()
    {
        // Arrange
        var number = -121;

        // Act
        bool result = number.IsPalindrome();

        // Assert
        Assert.IsFalse(result);
    }

    [Test]
    public void IsPalindrome_NumberIsNotPalindrome()
    {
        // Arrange
        var number = 10;

        // Act
        bool result = number.IsPalindrome();

        // Assert
        Assert.IsFalse(result);
    }
}