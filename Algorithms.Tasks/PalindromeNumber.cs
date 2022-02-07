namespace Algorithms.Tasks;

public static class PalindromeNumber
{
    /// <summary>
    /// Checks if <paramref name="number"/> is palindrome.
    /// </summary>
    /// <param name="number">Number to check.</param>
    /// <returns>True if <paramref name="number"/> is palindrome; false otherwise.</returns>
    public static bool IsPalindrome(this int number)
    {
        if (number < 0)
        {
            return false;
        }

        var digits = new List<int>();
        number.GetDigits(digits);
        for (int i = 0; i < digits.Count / 2; i++)
        {
            if (digits[i] != digits[^(i + 1)])
            {
                return false;
            }
        }

        return true;
    }

    private static void GetDigits(this int number, ICollection<int> digits)
    {
        while (number > 0)
        {
            var temp = number / 10;
            digits.Add(number - (temp * 10));
            number = temp;
        }
    }
}
