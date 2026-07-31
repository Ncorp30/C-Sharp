// Time:  O(n)
// Space: O(n)

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> lookup = new Dictionary<int, int>(nums.Length);
        for (int i = 0; i < nums.Length; i++) {
            int complementIndex;
            if (lookup.TryGetValue(target - nums[i], out complementIndex)) {
                return new int [] { complementIndex, i };
            }
            lookup[nums[i]] = i;
        }
        throw new System.InvalidOperationException("No two sum solution exists.");
    }
}
