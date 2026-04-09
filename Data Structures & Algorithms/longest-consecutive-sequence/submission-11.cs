public class Solution {
    public int LongestConsecutive(int[] nums) {
        var nSet = new HashSet<int>(nums);
        var longest = 0;

        foreach(var n in nSet)
        {
            if(nSet.Contains(n - 1))
                continue;

            var ptr = 1;
            while(nSet.Contains(n + ptr))
            {
                ptr++;
            }
            longest = Math.Max(longest, ptr);
        }

        return longest;
    }
}
