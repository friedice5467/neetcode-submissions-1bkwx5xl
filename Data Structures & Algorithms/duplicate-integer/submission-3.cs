public class Solution {
    public bool hasDuplicate(int[] nums) {
        var numSet = new HashSet<int>();

        foreach(var num in nums)
        {
            if(!numSet.Add(num))
                return true;
        }
        return false;
    }
}