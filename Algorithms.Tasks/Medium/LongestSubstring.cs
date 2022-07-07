namespace Algorithms.Tasks
{
    public static class LongestSubstring
    {
        /// <summary>
        /// Gets the length of the longest substring with unique characters.
        /// </summary>
        /// <param name="str">The source string.</param>
        /// <returns>The length of the longest substring with unique characters.</returns>
        public static int LengthOfLongestSubstring(this string str)
        {
            if (str.Length <= 1)
                return str.Length;

            int substringBeginning = 0, maxSubstringLength = 1;
            for (int i = 1; i <= str.Length; i++)
            {
                var substringLength = i - substringBeginning;
                if (i != str.Length && Contains(str, substringBeginning, substringLength, str[i]))
                {
                    if (substringLength > maxSubstringLength)
                    {
                        maxSubstringLength = substringLength;
                    }

                    // Abacd => aBacd
                    substringBeginning++;
                    i = substringBeginning;
                }

                if (i == str.Length && substringLength > maxSubstringLength)
                {
                    maxSubstringLength = substringLength;
                }
            }

            return maxSubstringLength;
        }

        private static bool Contains(string str, int startIndex, int length, char charToCheck)
        {
            for (int i = startIndex; i < startIndex + length; i++)
            {
                if (str[i].Equals(charToCheck))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
