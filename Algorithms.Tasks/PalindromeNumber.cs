namespace Algorithms.Tasks;

public static class PalindromeNumber
{
    public static bool IsPalindrome(this int number)
    {
        if (number < 0)
        {
            return false;
        }

        var digits = new List<int>();
        while (number > 0)
        {
            int temp = number / 10;
            var digit = number - (temp * 10);
            number = temp;
            digits.Add(digit);
        }

        for (int i = 0; i < digits.Count / 2; i++)
        {
            if (digits[i] != digits[^(i + 1)])
            {
                return false;
            }
        }

        return true;
    }
}
