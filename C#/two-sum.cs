// Time:  O(n)
// Space: O(n)

namespace TwoSumSolution
{
    public class Solution
    {
        /// <summary>
        /// Returns the indices of the two numbers that add up to the target.
        /// </summary>
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> lookup = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (lookup.TryGetValue(complement, out int index))
                {
                    return new int[] { index, i };
                }
                lookup[nums[i]] = i;
            }
            return new int[] { };
        }
    }
}