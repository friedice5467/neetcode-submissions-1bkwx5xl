public class Solution {
    public int[] GetConcatenation(int[] nums) {
        var n = nums.Length;
        var ans = new int[2*n];
        var j = 0;
        for(int i = 0; i < ans.Length; i++)
        {   if(j == n) j = 0;
            ans[i] = nums[j];
            j++;
        }

        return ans;
    }
}