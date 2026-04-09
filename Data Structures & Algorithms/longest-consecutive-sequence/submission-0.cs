public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length == 0)
            return 0;

        var nSet = nums.ToHashSet();
        int maxSeq = 0;

        foreach(var n in nSet)
        {
            if(nSet.Contains(n - 1))
                continue;
            else{
                var curSeq = 0;
                while(nSet.Contains(n + curSeq))
                {
                    curSeq++;
                }
                maxSeq = Math.Max(maxSeq, curSeq);
            }
        }

        return maxSeq;
    }
}
