namespace Algorithms.Tasks
{
    public static class ParenthesesValidator
    {
        /// <summary>
        /// Checks if given <paramref name="str"/> with parentheses is valid.
        /// An input string is valid if:
        /// <list type="bullet">
        /// <item>Open brackets must be closed by the same type of brackets.</item>
        /// <item>Open brackets must be closed in the correct order.</item>
        /// </list>
        /// </summary>
        /// <param name="str">String with parentheses to validate.</param>
        /// <returns>True, if <paramref name="str"/> is valid; false otherwise.</returns>
        public static bool IsValid(string str)
        {
            var brackets = new Stack<char>();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(' || str[i] == '[' || str[i] == '{')
                {
                    brackets.Push(str[i]);
                }
                else
                {
                    if (brackets.Count == 0)
                    {
                        return false;
                    }

                    var openBracket = brackets.Pop();
                    if ((openBracket == '(' && str[i] != ')') ||
                        (openBracket == '[' && str[i] != ']') ||
                        (openBracket == '{' && str[i] != '}'))
                    {
                        return false;
                    }
                }
            }

            if (brackets.Count != 0)
            {
                return false;
            }

            return true;
        }
    }
}
