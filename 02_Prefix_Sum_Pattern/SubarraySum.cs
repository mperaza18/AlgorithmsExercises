namespace AlgorithmsExercise._02_Prefix_Sum_Pattern;

public static class SubarraySum
{
    /*Given an array of integers nums and an integer k, return the total number of subarrays whose sum equals to k.

    A subarray is a contiguous non-empty sequence of elements within an array.

    Example 1:
    Input: nums = [1,1,1], k = 2
    Output: 2
    
    Example 2:
    Input: nums = [1,2,3], k = 3
    Output: 2

    Constraints:
    1 <= nums.length <= 2 * 104
    -1000 <= nums[i] <= 1000
    -107 <= k <= 107*/
    public static int Compute(int[] nums, int k)
    {
        var maxSum = 0;
        var count = 0;
        var sumFrequency = new Dictionary<int, int>();
        sumFrequency.Add(0, 1);

        for (int i = 0; i < nums.Length; i++)
        {
            maxSum += nums[i];
            sumFrequency[maxSum] = sumFrequency.GetValueOrDefault(maxSum) + 1;
            count += sumFrequency.GetValueOrDefault(maxSum - k);
        }

        return count;
    }
}