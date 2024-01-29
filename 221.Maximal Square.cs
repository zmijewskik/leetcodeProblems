using System;

public class Solution
{
    public int MaximalSquare(char[][] matrix)
    {
        int m = 0;

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                if (i == 0 || j == 0 || matrix[i][j] == '0')
                {
                    m = Math.Max(m, matrix[i][j] - '0');
                    continue;
                }

                int t = 1 + Math.Min(matrix[i - 1][j - 1],
                Math.Min(matrix[i - 1][j], matrix[i][j - 1]));
                matrix[i][j] = (char)t;
                m = Math.Max(m, t - '0');
            }
        }

        return m * m;
    }
}