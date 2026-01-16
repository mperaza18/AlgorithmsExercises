# Copilot Instructions for AlgorithmsExercises

## Project Overview
This is a C# algorithms practice repository structured as a .NET solution with LeetCode and algorithm pattern exercises. The main project (`src/AlgorithmsExercise.csproj`) targets .NET 8.0, while the test suite (`test/AlgorithmsExercises.Test/`) uses .NET 9.0 with xUnit.

## Architecture & Organization

### Directory Structure Pattern
- **Problem categories via folders**: Algorithms are organized by patterns (e.g., `02_Prefix_Sum_Pattern/`) or sources (e.g., `LeetCode/`, `L4/`)
- **Flat class files**: Each algorithm problem lives in its own file at the appropriate directory level
- **Mirrored test structure**: Test files follow the same folder hierarchy under `test/AlgorithmsExercises.Test/`

### Class Design Patterns

**Static vs Instance Classes:**
- Use **static classes** with static `Compute()` methods for pure algorithmic problems (see `ContiguousArray`, `SubarraySum`)
- Use **instance classes** with `Execute()` methods for object-oriented algorithm implementations (see `TwoSum`, `RemoveMinAndMax`)

**Example:**
```csharp
// Pattern problems: static
public static class ContiguousArray 
{
    public static int Compute(int[] nums) { ... }
}

// LeetCode problems: instance-based
public class TwoSum
{
    public int[] Execute(int[] nums, int target) { ... }
}
```

## Code Conventions

### Documentation Style
Every algorithm class **must** include:
1. **Problem statement** in XML docs or comments at the top
2. **Examples** with input/output scenarios
3. **Constraints** from the problem description
4. **Inline algorithm explanations** for key steps

Example from `RemoveMinAndMax.cs`:
```csharp
/// <summary>
/// Removing Minimum and Maximum from Array
/// [Full problem description here]
/// Example:
/// nums = [1, 2, -5, 3, 6, 4]
/// output = 4 = minimum number of deletions
/// </summary>
```

### Naming Conventions
- Namespace reflects folder structure: `AlgorithmsExercise._02_Prefix_Sum_Pattern`, `AlgorithmsExercise.L4`
- Method names: `Execute()` or `Compute()` for main algorithm entry points
- Test class suffix: `Tests` (e.g., `RemoveMinAndMaxTests`)

### Modern C# Features
- **Collection expressions** enabled: Use `[1, 2, 3]` instead of `new int[] { 1, 2, 3 }`
- **Implicit usings** enabled: No need to import `System`, `System.Collections.Generic`, etc.
- **Nullable reference types** enabled: Null handling is enforced

## Testing Standards

### xUnit Patterns
```csharp
[Fact]
public void Execute_WithExampleArray_ReturnsCorrectMinimumDeletions()
{
    // Arrange
    var solution = new RemoveMinAndMax();
    int[] nums = [1, 2, -5, 3, 6, 4];
    int expected = 4;

    // Act
    int result = solution.Execute(nums);

    // Assert
    Assert.Equal(expected, result);
}
```

- Use **AAA pattern**: Arrange, Act, Assert with comments
- Test method naming: `MethodName_Scenario_ExpectedBehavior`
- Use collection expressions in test data: `int[] nums = [1, 2, 3];`

## Development Workflows

### Building & Running
```bash
# Build main project
dotnet build src/AlgorithmsExercise.csproj

# Run tests
dotnet test test/AlgorithmsExercises.Test/AlgorithmsExercises.Test.csproj

# Run main program (exercises code in Program.cs)
dotnet run --project src/AlgorithmsExercise.csproj
```

### Testing Individual Solutions
The `Program.cs` serves as a scratch pad - uncomment the relevant section to test different algorithms manually. Most development should use xUnit tests instead.

## Adding New Problems

1. **Choose the appropriate folder** based on the problem category (or create a new pattern folder like `03_Sliding_Window/`)
2. **Create a class file** named after the problem (e.g., `TwoSum.cs`)
3. **Include full problem description** in comments/docs
4. **Create corresponding test file** in `test/AlgorithmsExercises.Test/` with the same folder structure
5. **Write multiple test cases** covering edge cases from the problem constraints

## Key Insights

- **ICompute interface** exists but is currently unused - likely a placeholder for future abstraction
- **Framework mismatch**: Main project uses .NET 8.0, tests use .NET 9.0 (tests reference the main project successfully)
- **No external algorithm libraries**: All solutions implemented from scratch
- **Problem-solving focus**: Code emphasizes clarity and algorithmic thinking over production patterns
