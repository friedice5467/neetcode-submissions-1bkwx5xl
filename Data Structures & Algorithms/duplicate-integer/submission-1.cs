public class Solution {
    public bool hasDuplicate(int[] nums) {
        var nSet = new HashSet<int>();

        foreach(var n in nums)
        {
            if (!nSet.Add(n))
                return true;
        }
        return false;
    }
}
