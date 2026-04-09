public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        var result = new List<List<int>>();

        for(int i = 0; i < nums.Length; i++)
        {
            var val = nums[i];

            if(i > 0 && val == nums[i - 1])
                continue;

            int l = i + 1;
            int r = nums.Length - 1;
            while(l < r)
            {
                var threeSum = val + nums[l] + nums[r];
                if(threeSum > 0)
                    r--;
                else if(threeSum < 0)
                    l++;
                else
                {
                    result.Add(new(){val, nums[l], nums[r]});
                    l++;
                    while(l < r && nums[l] == nums[l - 1])
                        l++;
                }
            }
        }
        return result;
    }
}
