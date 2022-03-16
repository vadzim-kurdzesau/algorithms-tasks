namespace Algorithms.Tasks;

public static class TwoSum
{
    /// <summary>
    /// Gets indices of two elements in <paramref name="nums"/> which sum equals <paramref name="target"/>.
    /// </summary>
    /// <param name="nums">Array of elements whose indices get.</param>
    /// <param name="target">Value that the sum of the elements in indices must equal.</param>
    /// <returns><see cref="ValueTuple"/> with both elements indices.</returns>
    /// <exception cref="ArgumentException">Thrown, if solution does not exist.</exception>
    public static (int firstIndex, int secondIndex) GetIndicesOfTwoNumbers(this int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] + nums[i] == target)
                {
                    return (i, j);
                }
            }
        }

        throw new ArgumentException($"There are no such elements in {nameof(nums)} which sum equals {target}.");
    }
}