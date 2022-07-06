using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Tasks;

namespace Algorithms.Tests.Utils
{
    public static class AssertWrapper
    {
        public static bool AreEqual(ListNode firstList, ListNode secondList)
        {
            while (firstList != null && secondList != null)
            {
                if (firstList.Value != secondList.Value)
                {
                    return false;
                }

                firstList = firstList.Next;
                secondList = secondList.Next;
            }

            if (firstList != null || secondList != null)
            {
                return false;
            }

            return true;
        }
    }
}
