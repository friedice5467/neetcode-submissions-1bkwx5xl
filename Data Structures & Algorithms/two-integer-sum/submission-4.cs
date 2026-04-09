public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var nMap = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            var diff = target - nums[i];
            if(nMap.ContainsKey(diff))
                return new int[]{nMap[diff], i};

            nMap[nums[i]] = i;
        }
        return null;
    }
}
