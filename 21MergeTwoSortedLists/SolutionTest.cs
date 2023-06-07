using Xunit;

namespace _21MergeTwoSortedLists
{
    public class SolutionTest
    {
        private readonly Solution _solution;
        public SolutionTest()
        {
            _solution = new Solution();
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 4 }, new int[] { 1, 3, 4 }, new int[] { 1, 1, 2, 3, 4, 4 })]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { }, new int[] { 1, 2, 3 })]
        [InlineData(new int[] { }, new int[] { 1, 3, 4 }, new int[] { 1, 3, 4 })]
        [InlineData(new int[] { }, new int[] { }, new int[] { })]
        public void TestMergeTwoLists(int[] list1, int[] list2, int[] expected)
        {
            // Arrange
            ListNode l1 = CreateLinkedList(list1);
            ListNode l2 = CreateLinkedList(list2);

            // Act
            ListNode result = _solution.MergeTwoLists(l1, l2);

            // Assert
            int[] actual = ConvertLinkedListToArray(result);
            Assert.Equal(expected, actual);
        }

        private ListNode CreateLinkedList(int[] values)
        {
            ListNode head = null;
            ListNode tail = null;
            foreach (int value in values)
            {
                ListNode node = new ListNode(value);
                if (head == null)
                {
                    head = node;
                    tail = node;
                }
                else
                {
                    tail.next = node;
                    tail = node;
                }
            }
            return head;
        }

        private int[] ConvertLinkedListToArray(ListNode head)
        {
            ListNode current = head;
            List<int> list = new List<int>();
            while (current != null)
            {
                list.Add(current.val);
                current = current.next;
            }
            return list.ToArray();
        }
    }
}
