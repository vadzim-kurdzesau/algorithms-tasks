﻿using Algorithms.Tasks;
using NUnit.Framework;

namespace Algorithms.Tests;

[TestFixture]
public class MergeTwoSortedListsTests
{
    [Test]
    public void MergeTwoLists_BothListsHaveEqualLengths_ReturnsMergedList()
    {
        // Arrange
        var firstList = new ListNode(1) { Next = new ListNode(2) { Next = new ListNode(4) } };
        var secondList = new ListNode(1) { Next = new ListNode(3) { Next = new ListNode(4) } };
        var expected = new ListNode(1)
        {
            Next = new ListNode(1)
            {
                Next = new ListNode(2)
                {
                    Next = new ListNode(3)
                    {
                        Next = new ListNode(4)
                        {
                            Next = new ListNode(4)
                        }
                    }
                }
            }
        };

        // Act
        var actual = firstList.MergeTwoLists(secondList);

        // Assert
        Assert.IsTrue(AreEqual(expected, actual));
    }

    [Test]
    public void MergeTwoLists_ListsHaveDifferentLengths_ReturnsMergedList()
    {
        // Arrange
        var firstList = new ListNode(1) { Next = new ListNode(4) };
        var secondList = new ListNode(1) { Next = new ListNode(3) { Next = new ListNode(4) } };
        var expected = new ListNode(1)
        {
            Next = new ListNode(1)
            {
                Next = new ListNode(3)
                {
                    Next = new ListNode(4)
                    {
                        Next = new ListNode(4)
                    }
                }
            }
        };

        // Act
        var actual = firstList.MergeTwoLists(secondList);

        // Assert
        Assert.IsTrue(AreEqual(expected, actual));
    }

    [Test]
    public void MergeTwoLists_BothListsAreEmpty_ReturnsEmptyList()
    {
        // Arrange
        ListNode firstList = null, secondList = null;

        // Act
        var actual = firstList.MergeTwoLists(secondList);

        // Assert
        Assert.Null(actual);
    }

    [Test]
    public void MergeTwoLists_OneListIsEmpty_ReturnsNotEmptyList()
    {
        // Arrange
        ListNode firstList = null;
        var secondList = new ListNode();

        // Act
        var actual = firstList.MergeTwoLists(secondList);

        // Assert
        Assert.IsTrue(AreEqual(secondList, actual));
    }

    private static bool AreEqual(ListNode firstList, ListNode secondList)
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
