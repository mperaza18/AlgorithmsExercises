namespace AlgorithmsExercise._02_Prefix_Sum_Pattern;

public static class ContiguousArray
{
    /*Given a binary array nums, return the maximum length of a contiguous subarray with an equal number of 0 and 1.

    Example 1:
    Input: nums = [0,1]
    Output: 2
    Explanation: [0, 1] is the longest contiguous subarray with an equal number of 0 and 1.
    
    Example 2:
    Input: nums = [0,1,0]
    Output: 2
    Explanation: [0, 1] (or [1, 0]) is a longest contiguous subarray with equal number of 0 and 1.
    
    Example 3:
    Input: nums = [0,1,1,1,1,1,0,0,0]
    Output: 6
    Explanation: [1,1,1,0,0,0] is the longest contiguous subarray with equal number of 0 and 1.
 
    Constraints:
    1 <= nums.length <= 105
    nums[i] is either 0 or 1.*/
    public static int Compute(int[] nums)
    {
        // Dictionary to store: sum -> first index where this sum occurred
        var sumToIndex = new Dictionary<int, int>();

        // Very important: sum = 0 at index -1 (before the array starts)
        sumToIndex[0] = -1;

        int maxLen = 0;
        int sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            // Treat 0 as -1 and 1 as +1
            if (nums[i] == 0)
            {
                sum += -1;
            }
            else
            {
                sum += 1;
            }

            // If we have seen this sum before, we found a subarray with equal 0s and 1s
            if (sumToIndex.ContainsKey(sum))
            {
                int prevIndex = sumToIndex[sum];
                int currentLen = i - prevIndex;

                if (currentLen > maxLen)
                {
                    maxLen = currentLen;
                }
            }
            else
            {
                // First time we see this sum, store the index
                sumToIndex[sum] = i;
            }
        }

        return maxLen;
    }
}