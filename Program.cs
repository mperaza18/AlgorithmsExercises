// See https://aka.ms/new-console-template for more information

using AlgorithmsExercise;

Console.WriteLine("Hello, World!");

/*Palindrome*/
//var input = "A man, a plan, a canal: Panama";
//var result = PalindromeValidator.IsPalindrome("A man, a plan, a canal: Panama");
//var result = PalindromeValidator.IsPalindrome2(input);
//Console.WriteLine($"Result. {input} is palindrome: {result}");

/*Cinema Seat Allocation*/
/*var n = 3;
var reservedSeats = new int[][] { new int[] { 1, 2 }, new int[] { 1, 3 }, new int[] { 1, 8 }, new int[] { 2, 6 }, new int[] { 3, 1 }, new int[] { 3, 10 } };
var solution = new CinemaSeatAllocation();
Console.WriteLine(solution.MaxNumberOfGroups(n, reservedSeats)); */

/*Zigzag Conversion*/
var solution = new ZigzagConversion();
var result = solution.Convert("PAYPALISHIRING", 3);
Console.WriteLine(result);
