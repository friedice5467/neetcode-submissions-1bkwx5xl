public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var difference = target - nums[i];

            if (map.TryGetValue(difference, out var index))
                return new[] { index, i };

            map[nums[i]] = i;
        }
        return [];
    }
}
