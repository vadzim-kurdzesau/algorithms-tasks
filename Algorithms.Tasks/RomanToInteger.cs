namespace Algorithms.Tasks
{
    public static class RomanToInteger
    {
        /// <summary>
        /// Contains roman numeral symbols with their integer representations.
        /// </summary>
        private static readonly Dictionary<char, int> Symbols = new ()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
        };

        /// <summary>
        /// Converts given roman numeral <paramref name="str"/> to an integer.
        /// </summary>
        /// <param name="str">Roman numeral string to convert.</param>
        /// <returns>Converted to integer roman numeral <paramref name="str"/>.</returns>
        public static int RomanToInt(this string str)
        {
            int result = 0;

            for (int i = 0; i < str.Length; i++)
            {
                Symbols.TryGetValue(str[i], out int value);

                if (i < str.Length - 1)
                {
                    if (str[i] == 'I')
                    {
                        if (str[i + 1] == 'V')
                        {
                            value = 4;
                            i++;
                        }
                        else if (str[i + 1] == 'X')
                        {
                            value = 9;
                            i++;
                        }
                    }
                    else if (str[i] == 'X')
                    {
                        if (str[i + 1] == 'L')
                        {
                            value = 40;
                            i++;
                        }
                        else if (str[i + 1] == 'C')
                        {
                            value = 90;
                            i++;
                        }
                    }
                    else if (str[i] == 'C')
                    {
                        if (str[i + 1] == 'D')
                        {
                            value = 400;
                            i++;
                        }
                        else if (str[i + 1] == 'M')
                        {
                            value = 900;
                            i++;
                        }
                    }
                }

                result += value;
            }

            return result;
        }
    }
}
