using System;
using System.Text;

public static class PalindromeValidator {
    public static bool IsPalindrome(string input)
    {
        var trimInput = input.Trim(' ');
        var length = trimInput.Length;
        
        var newText = new StringBuilder();
        for (int i = length-1; i >= 0; i--)
        {
            if ((trimInput[i] >= '0' && trimInput[i] <= '9')
                || (trimInput[i] >= 'A' && trimInput[i] <= 'Z')
                || (trimInput[i] >= 'a' && trimInput[i] <= 'z')) {
                newText.Append(trimInput[i]);
            }
        }
        Console.WriteLine($"New Text: {newText}");
        
        return string.Equals(newText.ToString(), trimInput);
    }
    
    // Method to check if a string is a palindrome
    public static bool IsPalindrome2(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return false;
        }

        // Remove whitespace and convert to lower case for case-insensitive comparison
        string cleanedInput = RemoveNonAlphanumericCharacters(input.ToLower());

        int length = cleanedInput.Length;

        // Check if the string reads the same forward and backward
        for (int i = 0; i < length / 2; i++)
        {
            if (cleanedInput[i] != cleanedInput[length - 1 - i])
            {
                return false;
            }
        }

        return true;
    }
    
    // Helper method to remove non-alphanumeric characters from the string
    private static string RemoveNonAlphanumericCharacters(string input)
    {
        char[] arr = input.ToCharArray();
        arr = Array.FindAll<char>(arr, (c => char.IsLetterOrDigit(c)));
        return new string(arr);
    }
}