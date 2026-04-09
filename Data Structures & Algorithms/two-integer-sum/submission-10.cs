public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var numMap = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            var num = nums[i];
            var val2 = target - num;
            if(numMap.TryGetValue(val2, out int index)){
                if(i == index) continue;
                return new int[]{index, i};
            }

            numMap[num] = i;
        }

        return new int[0];
    }
}
