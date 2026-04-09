public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length == 0) return 0;
        var nSet = nums.ToHashSet();
        var highestSeq = 0;
        foreach(var n in nSet)
        {
            if(nSet.Contains(n-1))
                continue;

            var curr = 0;
            while(nSet.Contains(n+curr))
            {
                curr++;
            }
            highestSeq = Math.Max(highestSeq, curr);
        }

        return highestSeq;
    }
}
