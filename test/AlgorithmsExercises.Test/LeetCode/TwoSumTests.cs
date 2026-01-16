namespace AlgorithmsExercises.Test.LeetCode;

public class TwoSumTests
{
    [Fact]
    public void Execute_WithBasicExample_ReturnsCorrectIndices()
    {
        // Arrange
        var solution = new TwoSum();
        int[] nums = [2, 7, 11, 15];
        int target = 9;
        int[] expected = [0, 1];

        // Act
        int[] result = solution.Execute(nums, target);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Execute_WithDuplicateNumbers_ReturnsCorrectIndices()
    {
        // Arrange
        var solution = new TwoSum();
        int[] nums = [3, 3];
        int target = 6;
        int[] expected = [0, 1];

        // Act
        int[] result = solution.Execute(nums, target);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Execute_WithNonSequentialIndices_ReturnsCorrectIndices()
    {
        // Arrange
        var solution = new TwoSum();
        int[] nums = [3, 2, 4];
        int target = 6;
        int[] expected = [1, 2];

        // Act
        int[] result = solution.Execute(nums, target);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Execute_WithMultipleDuplicatesAndDistantIndices_ReturnsCorrectIndices()
    {
        // Arrange
        var solution = new TwoSum();
        int[] nums = [1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1];
        int target = 11;
        int[] expected = [5, 11];

        // Act
        int[] result = solution.Execute(nums, target);

        // Assert
        Assert.Equal(expected, result);
    }
}
