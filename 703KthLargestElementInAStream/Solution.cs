using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _703KthLargestElementInAStream
{
    public class Solution
    {
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        private static int kth = 1;
        public Solution(int k, int[] nums)
        {
            kth = k;
            foreach (var v in nums)
            {
                Add(v);
            }
        }

        public int Add(int val)
        {
            pq.Enqueue(val, val);
            if (pq.Count > kth)
            {
                pq.Dequeue();
            }
            return pq.Peek();
        }
    }
}
