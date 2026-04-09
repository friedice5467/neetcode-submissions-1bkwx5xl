public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var cSet = new HashSet<char>();
        var max = 0;
        var l = 0;
        for(int r = 0; r < s.Length; r++)
        {
            while(cSet.Contains(s[r]))
            {
                cSet.Remove(s[l]);
                l++;
            }
            cSet.Add(s[r]);
            max = Math.Max(max, r - l + 1);
        }
        return max;
    }
}
