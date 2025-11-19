namespace AlgorithmsExercise;

public class MaximumAverageSubarray_I
{
    /*You are given an integer array nums consisting of n elements, and an integer k.

        Find a contiguous subarray whose length is equal to k that has the maximum average value and return this value. Any answer with a calculation error less than 10-5 will be accepted.

 

        Example 1:

    Input: nums = [1,12,-5,-6,50,3], k = 4
    Output: 12.75000
    Explanation: Maximum average is (12 - 5 - 6 + 50) / 4 = 51 / 4 = 12.75
    Example 2:

    Input: nums = [5], k = 1
    Output: 5.00000
 

    Constraints:

    n == nums.length
    1 <= k <= n <= 105
    -104 <= nums[i] <= 104*/
    public double FindMaxAverage(int[] nums, int k)
    {
        double windowSum = 0;
        double maxSum = double.MinValue;

        for (int i = 0; i < nums.Length; i++)
        {
            // Add current element into the window
            windowSum += nums[i];

            // Once we have k elements, start sliding
            if (i >= k)
            {
                // Remove the element that goes out of the window
                windowSum -= nums[i - k];
            }

            // Start tracking max once the first window is complete
            if (i >= k - 1)
            {
                maxSum = Math.Max(maxSum, windowSum);
            }
        }

        return maxSum / k;
    }
}