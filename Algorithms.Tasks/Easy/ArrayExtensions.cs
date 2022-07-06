namespace Algorithms.Tasks
{
    /// <summary>
    /// Contains the array extension methods.
    /// </summary>
    public static class ArrayExtensions
    {
        /// <summary>
        /// Removes the duplicates in-place such that each unique element appears only once keeping the same relative order.
        /// </summary>
        /// <param name="nums">An integer array of numbers sorted in non-decreasing order.</param>
        /// <returns>The number of unique elements placed in the first <paramref name="nums"/> slots.</returns>
        public static int RemoveDuplicates(this int[] nums)
        {
            if (nums.Length == 1)
                return 1;

            int currentNum = nums[0], k = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (currentNum != nums[i])
                {
                    nums[++k] = nums[i];
                    currentNum = nums[i];
                }
            }

            return ++k;
        }
    }
}
