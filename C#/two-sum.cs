// Time:  O(n)
// Space: O(n)

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> lookup = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            if (lookup.TryGetValue(complement, out int index)) {
                return new int [] { index, i };
            }
            lookup[nums[i]] = i;
        }
        return new int[] { };
    }
}
