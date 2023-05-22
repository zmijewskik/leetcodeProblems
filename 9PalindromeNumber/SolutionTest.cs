using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace _9PalindromeNumber
{
    public class SolutionTest
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(121)]
        [InlineData(9889)]
        public void PalindromeNumber_ShouldReturnTrueWhenNumberIsAPalindrome(int input)
        {
            // Arrange
            var solution = new Solution();

            // Act
            var result = solution.IsPalindrome(input);

            // Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData(1234)]
        [InlineData(-121)]
        public void PalindromeNumber_ShouldReturnFalseWhenNumberIsNotAPalindrome(int input)
        {
            // Arrange
            var solution = new Solution();

            // Act
            var result = solution.IsPalindrome(input);

            // Assert
            Assert.False(result);
        }
    }

    //public class SolutionTests
    //{
    //    [Theory]
    //    [InlineData(new[] { 2, 4, 3 }, new[] { 5, 6, 4 }, new[] { 7, 0, 8 })]
    //    [InlineData(new[] { 0 }, new[] { 0 }, new[] { 0 })]
    //    [InlineData(new[] { 9, 9, 9 }, new[] { 1 }, new[] { 0, 0, 0, 1 })]
    //    public void AddTwoNumbers_ShouldReturnExpectedResult(int[] input1, int[] input2, int[] expected)
    //    {
    //        Arrange
    //       var l1 = CreateLinkedList(input1);
    //        var l2 = CreateLinkedList(input2);
    //        var expectedList = CreateLinkedList(expected);

    //        var solution = new Solution();

    //        Act
    //       var result = solution.AddTwoNumbers(l1, l2);

    //        Assert
    //        AssertLinkedListEquals(expectedList, result);
    //    }

    //    private ListNode CreateLinkedList(int[] values)
    //    {
    //        if (values == null || values.Length == 0) return null;

    //        ListNode head = new ListNode(values[0]);
    //        ListNode current = head;

    //        for (int i = 1; i < values.Length; i++)
    //        {
    //            current.next = new ListNode(values[i]);
    //            current = current.next;
    //        }

    //        return head;
    //    }

    //    private void AssertLinkedListEquals(ListNode expected, ListNode actual)
    //    {
    //        while (expected != null && actual != null)
    //        {
    //            Assert.Equal(expected.val, actual.val);
    //            expected = expected.next;
    //            actual = actual.next;
    //        }

    //        Assert.Null(expected);
    //        Assert.Null(actual);
    //    }
    //}
}
