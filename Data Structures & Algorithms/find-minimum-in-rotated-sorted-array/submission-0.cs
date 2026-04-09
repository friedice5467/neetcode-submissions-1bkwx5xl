public class Solution {
    public int FindMin(int[] nums) {
        var l = 0;
        var r = nums.Length - 1;

        while(l <= r)
        {
            var m = l + (r - l) / 2;

            if(nums[l] <= nums[r])
                return nums[l];

            if(nums[m] >= nums[l])
                l = m + 1;
            else
                r = m;
        }

        return 0;
    }
}
