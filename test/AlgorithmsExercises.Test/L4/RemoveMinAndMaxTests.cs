using AlgorithmsExercise.L4;
using Xunit;

namespace AlgorithmExercise.Test.L4
{
    public class RemoveMinAndMaxTests
    {
        [Fact]
        public void Execute_WithExampleArray_ReturnsCorrectMinimumDeletions()
        {
            // Arrange
            var removeMinAndMax = new RemoveMinAndMax();
            int[] nums = [1, 2, -5, 3, 6, 4];
            int expected = 4; // Based on the algorithm logic

            // Act
            int result = removeMinAndMax.Execute(nums);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Execute_WithTwoElements_ReturnsTwo()
        {
            // Arrange
            var removeMinAndMax = new RemoveMinAndMax();
            int[] nums = { 1, 2 };
            int expected = 2;

            // Act
            int result = removeMinAndMax.Execute(nums);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Execute_WithSingleElement_ReturnsOne()
        {
            // Arrange
            var removeMinAndMax = new RemoveMinAndMax();
            int[] nums = { 5 };
            int expected = 1;

            // Act
            int result = removeMinAndMax.Execute(nums);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Execute_WithMinAtStart_ReturnsOptimalDeletions()
        {
            // Arrange
            var removeMinAndMax = new RemoveMinAndMax();
            int[] nums = [-1, 5, 3, 2, 4];
            int expected = 2;

            // Act
            int result = removeMinAndMax.Execute(nums);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Execute_WithMaxAtEnd_ReturnsOptimalDeletions()
        {
            // Arrange
            var removeMinAndMax = new RemoveMinAndMax();
            int[] nums = { 3, 1, 2, 4, 10 };
            int expected = 3;

            // Act
            int result = removeMinAndMax.Execute(nums);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Execute_WithMinAndMaxAtEnds_ReturnsOptimalDeletions()
        {
            // Arrange
            var removeMinAndMax = new RemoveMinAndMax();
            int[] nums = { -5, 3, 2, 1, 10 };
            int expected = 2;

            // Act
            int result = removeMinAndMax.Execute(nums);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Execute_WithMinAndMaxInMiddle_ReturnsOptimalDeletions()
        {
            // Arrange
            var removeMinAndMax = new RemoveMinAndMax();
            int[] nums = { 1, 2, -5, 10, 3, 4 };
            int expected = 4;

            // Act
            int result = removeMinAndMax.Execute(nums);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Execute_WithNegativeNumbers_ReturnsCorrectResult()
        {
            // Arrange
            var removeMinAndMax = new RemoveMinAndMax();
            int[] nums = { -10, -5, -2, -1 };
            int expected = 2;

            // Act
            int result = removeMinAndMax.Execute(nums);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Execute_WithIdenticalElements_ReturnsOne()
        {
            // Arrange
            var removeMinAndMax = new RemoveMinAndMax();
            int[] nums = { 5, 5, 5, 5 };
            int expected = 1;

            // Act
            int result = removeMinAndMax.Execute(nums);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Execute_WithLargeArray_ReturnsOptimalDeletions()
        {
            // Arrange
            var removeMinAndMax = new RemoveMinAndMax();
            int[] nums = { 2, 10, 7, 5, 4, 1, 8, 6 };
            int expected = 5;

            // Act
            int result = removeMinAndMax.Execute(nums);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}