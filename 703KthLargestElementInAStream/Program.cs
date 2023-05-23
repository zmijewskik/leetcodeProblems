Console.WriteLine("703KthLargestElementInAStream!");

//int[] nums = new int[] { 4, 5, 8, 2 };
//KthLargest kthLargest = new KthLargest(3, nums);
//kthLargest.Add(3);
//kthLargest.Add(5);
//kthLargest.Add(10);
//kthLargest.Add(9);
//kthLargest.Add(8);

public class KthLargest
{
    PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
    private static int kth = 1;
    public KthLargest(int k, int[] nums)
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