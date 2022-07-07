using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Tasks
{
    public static class ZigzagConversion
    {
        /// <summary>
        /// Writes the <paramref name="str"/> in a zigzag pattern.
        /// </summary>
        /// <param name="str">The string to convert.</param>
        /// <param name="numberOfRows">The number of rows in a zigzag pattern.</param>
        /// <returns>The converted in a zigzag pattern <paramref name="str"/>.</returns>
        public static string Convert(this string str, int numberOfRows)
        {
            var table = new StringBuilder[numberOfRows];
            for (int j = 0; j < numberOfRows; j++)
            {
                table[j] = new StringBuilder(str.Length);
            }

            var i = 0;
            while (i < str.Length)
            {
                // Filling vertically
                for (int j = 0; j < numberOfRows && i < str.Length; j++)
                {
                    table[j].Append(str[i++]);
                }

                // Creating a diagonal
                for (int j = numberOfRows - 2; j > 0 && i < str.Length; j--)
                {
                    table[j].Append(str[i++]);
                }
            }

            var result = new StringBuilder(str.Length);
            for (int j = 0; j < table.Length; j++)
            {
                result.Append(table[j]);
            }

            return result.ToString();
        }
    }
}
