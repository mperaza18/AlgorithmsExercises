namespace AlgorithmsExercise.L4;

/// <summary>
/// Removing Minimum and Maximum from Array
/// You are given a 0-indexed array of distinct integers nums.
///
/// There is an element in nums that has the lowest value and an element that has the highest value.
/// We call them the minimum and maximum respectively. Your goal is to remove both of there elements from the array.
///
/// A deletion is defined as either removing an element from the front of the array or removing an element from
/// the back of the array.
///
/// Return the minimum number of deletions it would take to remove both the minimum and maximum
/// element from the array.
///
/// Example:
/// nums = [1, 2, -5, 3, 6, 4]
/// lowest = -5
/// highest = 6
/// output = 4 = minimum number of deletions
/// </summary>
public class RemoveMinAndMax
{
    public int Execute(int[] nums)
    {
        // 1st find the lowest and highest values
        int n = nums.Length;

        var minValue = nums[0];
        var maxValue = nums[0];
        int iMin = 0;
        int iMax = 0;

        for (int i = 1; i < n; i++)
        {
            if(nums[i] < minValue)
            {
                minValue = nums[i];
                iMin = i;
            }
            
            if(nums[i] > maxValue)
            {
                maxValue = nums[i];
                iMax = i;
            }
        }
        
        // 2nd Calculate the number of deletions on the left, right and both sides.
        var left = Math.Min(iMin, iMax);
        var right = Math.Max(iMin, iMax);

        var numOfDeletionsLeft = right + 1;
        var numOfDeletionsRight = n - left;
        var bothSides = (left + 1) + (n - right);
        
        // return the minimum
        var min1 = Math.Min(bothSides, numOfDeletionsRight);
        var min2 = Math.Min(min1, numOfDeletionsLeft);

        return Math.Min(min1, min2);
    }
}