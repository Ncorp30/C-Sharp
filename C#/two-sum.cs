// Time:  O(n)
// Space: O(n)

public class TwoSumSolver {
    /// <summary>
    /// Returns the indices of the two numbers such that they add up to the target.
    /// Throws if no valid pair exists.
    /// </summary>
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> lookup = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++) {
            if (lookup.TryGetValue(target - nums[i], out var index)) {
                return new int [] { index, i };
            }
            lookup[nums[i]] = i;
        }
        throw new InvalidOperationException("No two sum solution exists.");
    }
}
