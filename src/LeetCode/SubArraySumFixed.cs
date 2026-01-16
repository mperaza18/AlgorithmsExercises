// Fixed Size Sliding Window
// Given an array (list)  nums consisted of only non-negative integers, find the largest sum among all subarrays of length k in nums.

// Example 1:
// Input: nums = [1,2,3,7,4,1], k = 3
// Output: 14 
// Explanation: Subarray with maximum sum is [3,7,4] with sum 14.
class SubArraySumFixed
{
    public int Execute(int[] nums, int k)
    {
        int maxSum = 0;
        int windowSum = 0;
        int windowStart = 0;

        for (int windowEnd = 0; windowEnd < nums.Length; windowEnd++)
        {
            windowSum += nums[windowEnd];

            if (windowEnd >= k - 1)
            {
                maxSum = Math.Max(maxSum, windowSum);
                windowSum -= nums[windowStart];
                windowStart++;
            }
        }

        return maxSum;
    }
}