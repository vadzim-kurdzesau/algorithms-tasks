using Algorithms.Tasks;
using NUnit.Framework;

namespace Algorithms.Tests;

[TestFixture]
public class PalindromeNumberTests
{
    [Test]
    public void PalindromeNumberTests_NumberIsPalindrome()
    {
        // Arrange
        var number = 121;

        // Act
        bool result = number.IsPalindrome();

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void PalindromeNumberTests_NumberIsNegative_NumberIsNotPalindrome()
    {
        // Arrange
        var number = -121;

        // Act
        bool result = number.IsPalindrome();

        // Assert
        Assert.IsFalse(result);
    }

    [Test]
    public void PalindromeNumberTests_NumberIsNotPalindrome()
    {
        // Arrange
        var number = 10;

        // Act
        bool result = number.IsPalindrome();

        // Assert
        Assert.IsFalse(result);
    }
}