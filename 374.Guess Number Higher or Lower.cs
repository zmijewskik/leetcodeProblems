/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame
{
    public int GuessNumber(int n)
    {
        int low = 1;
        int high = n;

        while (low <= high)
        {
            // Find the middle point
            int mid = low + (high - low) / 2;

            // Call the pre-defined API to get feedback
            int result = guess(mid);

            // Check if we have found the answer
            if (result == 0)
            {
                return mid;
            }

            // Check if we need to search in the left half
            else if (result == -1)
            {
                high = mid - 1;
            }

            // Check if we need to search in the right half
            else
            {
                low = mid + 1;
            }
        }

        // Return -1 if no answer is found
        return -1;
    }
}