// Find the length of the longest substring of a given string without repeating characters.
//
// Example 1:
// Input: s = "abccabcabcc"
// Output: 3
// Explanation: The answer is "abc" and "cab", both of length 3.
public class LongestSubstring
{
    public int Execute(string s)
    {
        int maxLength = 0;
        int windowStart = 0;
        var charIndexMap = new Dictionary<char, int>();

        for (int windowEnd = 0; windowEnd < s.Length; windowEnd++)
        {
            char rightChar = s[windowEnd];

            if (charIndexMap.ContainsKey(rightChar))
            {
                windowStart = Math.Max(windowStart, charIndexMap[rightChar] + 1);
            }

            charIndexMap[rightChar] = windowEnd;
            maxLength = Math.Max(maxLength, windowEnd - windowStart + 1);
        }

        return maxLength;
    }
}