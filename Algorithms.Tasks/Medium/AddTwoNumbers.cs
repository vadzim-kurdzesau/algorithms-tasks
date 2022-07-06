namespace Algorithms.Tasks
{
    public static class AddTwoNumbers
    {
        /// <summary>
        /// Adds two non-empty linked lists representing two non-negative integers.
        /// </summary>
        /// <param name="first">The first list.</param>
        /// <param name="second">The second list.</param>
        /// <returns>The sum of the <paramref name="first"/> and the <paramref name="second"/> lists.</returns>
        public static ListNode Add(this ListNode first, ListNode second)
        {
            var sum = first.Value + second.Value;
            var reminder = 0;
            if (sum >= 10)
            {
                sum -= 10;
                reminder = 1;
            }

            var result = new ListNode(sum);

            var currentNodeResult = result;
            var currentNodeFirst = first.Next;
            var currentNodeSecond = second.Next;

            while (currentNodeFirst != null)
            {
                var secondValue = 0;
                if (currentNodeSecond != null)
                {
                    secondValue = currentNodeSecond.Value;
                    currentNodeSecond = currentNodeSecond.Next;
                }

                CalculateSum(ref currentNodeFirst, ref currentNodeResult, ref reminder, secondValue);
            }

            while (currentNodeSecond != null)
            {
                CalculateSum(ref currentNodeSecond, ref currentNodeResult, ref reminder);
            }

            if (reminder != 0)
            {
                currentNodeResult.Next = new ListNode(reminder);
            }

            return result;
        }

        private static void CalculateSum(ref ListNode currentNode, ref ListNode result, ref int reminder, int secondValue = 0)
        {
            var sum = currentNode.Value + secondValue + reminder;
            if (sum >= 10)
            {
                reminder = 1;
                sum -= 10;
            }
            else
            {
                reminder = 0;
            }

            result.Next = new ListNode(sum);
            result = result.Next;

            currentNode = currentNode.Next;
        }
    }
}
