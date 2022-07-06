using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Tasks
{
    public class ListNode
    {
        public int Value { get; set; }

        public ListNode Next { get; set; }

        public ListNode(int value = default, ListNode next = default)
        {
            this.Value = value;
            this.Next = next;
        }
    }
}
