public class Solution {
    public int Search(int[] nums, int target) {
        var l = 0;
        var r = nums.Length - 1;

        while(l <= r)
        {
            var m = l + (r - l) / 2;

            if(nums[m] == target)
                return m;

            if(nums[l] <= nums[m])
            {
                if(nums[l] <= target && nums[m] > target)
                    r = m - 1;
                else
                    l = m + 1;
            }
            else
            {
                if(nums[r] >= target && nums[m] < target)
                    r = m - 1;
                else
                    l = m + 1;
            }
        }

        return -1;
    }
}
