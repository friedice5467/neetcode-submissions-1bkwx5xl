public class Solution {
    public int LongestConsecutive(int[] nums) {
        var nSet = new HashSet<int>(nums);
        var max = 0;

        foreach(var n in nums)
        {
            if(nSet.Contains(n - 1))
                continue;

            var counter = 0;
            while(nSet.Contains(n + counter))
            {
                counter++;
                max = Math.Max(max, counter);
            }

        }
        return max;
    }
}
