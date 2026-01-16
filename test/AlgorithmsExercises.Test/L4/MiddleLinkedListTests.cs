namespace AlgorithmsExercises.Test.L4;

public class MiddleLinkedListTests
{
    [Fact]
    public void Execute_WithOddNumberOfNodes_ReturnsMiddleNode()
    {
        // Arrange
        var solution = new MiddleLinkedList();
        ListNode head = CreateLinkedList([0, 1, 2, 3, 4]);
        int expected = 2;

        // Act
        ListNode result = solution.Execute(head);

        // Assert
        Assert.Equal(expected, result.val);
    }

    [Fact]
    public void Execute_WithEvenNumberOfNodes_ReturnsSecondMiddleNode()
    {
        // Arrange
        var solution = new MiddleLinkedList();
        ListNode head = CreateLinkedList([0, 1, 2, 3, 4, 5]);
        int expected = 3;

        // Act
        ListNode result = solution.Execute(head);

        // Assert
        Assert.Equal(expected, result.val);
    }

    [Fact]
    public void Execute_WithSingleNode_ReturnsThatNode()
    {
        // Arrange
        var solution = new MiddleLinkedList();
        ListNode head = CreateLinkedList([42]);
        int expected = 42;

        // Act
        ListNode result = solution.Execute(head);

        // Assert
        Assert.Equal(expected, result.val);
    }

    [Fact]
    public void Execute_WithTwoNodes_ReturnsSecondNode()
    {
        // Arrange
        var solution = new MiddleLinkedList();
        ListNode head = CreateLinkedList([1, 2]);
        int expected = 2;

        // Act
        ListNode result = solution.Execute(head);

        // Assert
        Assert.Equal(expected, result.val);
    }

    /// <summary>
    /// Helper method to create a linked list from an array of values
    /// </summary>
    private ListNode CreateLinkedList(int[] values)
    {
        if (values.Length == 0)
            throw new ArgumentException("Array must have at least one element");

        ListNode head = new ListNode(values[0]);
        ListNode current = head;

        for (int i = 1; i < values.Length; i++)
        {
            current.next = new ListNode(values[i]);
            current = current.next;
        }

        return head;
    }
}
