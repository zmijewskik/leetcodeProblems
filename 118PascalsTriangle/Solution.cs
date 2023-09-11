//Example 1:

//Input: numRows = 5
//Output: [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]

//Example 2:

//Input: numRows = 1
//Output: [[1]]

namespace _118PascalsTriangle
{
    // Dynamic Programming approach
    public class Solution
    {
        public IList<IList<int>> Generate(int numRows)
        {
            List<IList<int>> triangle = new List<IList<int>>();
            if (numRows == 0) return triangle;

            triangle.Add(new List<int>() { 1 });

            for (int i = 1; i < numRows; i++)
            {
                List<int> prevRow = (List<int>)triangle[i - 1];
                List<int> newRow = new List<int> { 1 };

                for (int j = 1; j < prevRow.Count; j++)
                {
                    newRow.Add(prevRow[j - 1] + prevRow[j]);
                }

                newRow.Add(1);
                triangle.Add(newRow);
            }

            return triangle;
        }
    }
}