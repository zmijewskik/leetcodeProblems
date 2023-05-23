using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace _703KthLargestElementInAStream
{
    public class KthLargestTest
    {
        [Fact]
        public void TestKthLargest()
        {
            // Arrange
            int[] nums = new int[] { 4, 5, 8, 2 };
            KthLargest kthLargest = new KthLargest(3, nums);

            // Act and Assert
            Assert.Equal(4, kthLargest.Add(3)); // return 4
            Assert.Equal(5, kthLargest.Add(5)); // return 5
            Assert.Equal(5, kthLargest.Add(10)); // return 5
            Assert.Equal(8, kthLargest.Add(9)); // return 8
            Assert.Equal(8, kthLargest.Add(4)); // return 8
        }
    }
}
