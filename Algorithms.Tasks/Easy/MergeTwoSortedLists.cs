namespace Algorithms.Tasks
{
    public static class MergeTwoSortedLists
    {
        public static ListNode MergeTwoLists(this ListNode list1, ListNode list2)
        {
            var tempNode = new ListNode();
            var lastNode = tempNode;

            while (true)
            {
                if (list1 == null)
                {
                    lastNode.Next = list2;
                    break;
                }

                if (list2 == null)
                {
                    lastNode.Next = list1;
                    break;
                }

                if (list1.Value <= list2.Value)
                {
                    lastNode.Next = list1;
                    list1 = list1.Next;
                }
                else
                {
                    lastNode.Next = list2;
                    list2 = list2.Next;
                }

                lastNode = lastNode.Next;
            }

            return tempNode.Next;
        }
    }
}
