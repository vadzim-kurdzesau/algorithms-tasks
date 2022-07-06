using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Tasks
{
    /// <summary>
    /// Constains the string extension methods.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Returns the index of the <paramref name="needle"/> in the <paramref name="haystack"/>.
        /// </summary>
        /// <param name="haystack">The source string.</param>
        /// <param name="needle">The string to find.</param>
        /// <returns>The index of the <paramref name="needle"/> in the <paramref name="haystack"/>; -1 if doesn't exitst.</returns>
        public static int IntersectWith(this string haystack, string needle)
        {
            if (needle.Length == 0)
                return 0;

            for (int i = 0; i < haystack.Length - needle.Length + 1; i++)
            {
                if (haystack[i].Equals(needle[0]))
                {
                    var foundValue = true;
                    for (int j = 1; j < needle.Length; j++)
                    {
                        if (haystack[i + j] != needle[j])
                        {
                            foundValue = false;
                            break;
                        }
                    }

                    if (foundValue)
                        return i;
                }
            }

            return -1;
        }
    }
}
