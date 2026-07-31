using System;
using System.Collections.Generic;

// Time:  O(n)
// Space: O(n)

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> lookup = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++) {
            int complementIndex;
            if (lookup.TryGetValue(target - nums[i], out complementIndex)) {
                return new int [] { complementIndex, i };
            }
            lookup[nums[i]] = i;
        }
        return new int[] { };
    }
}
