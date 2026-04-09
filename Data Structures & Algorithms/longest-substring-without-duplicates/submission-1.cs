public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var cSet = new HashSet<char>();
        var max = 0;
        var winStart = 0;

        for(int winEnd = 0; winEnd < s.Length; winEnd++)
        {   
            while(cSet.Contains(s[winEnd]))
            {
                cSet.Remove(s[winStart]);
                winStart++;
            }
            cSet.Add(s[winEnd]);
            max = Math.Max(max, winEnd - winStart + 1);
        }
        return max;
    }
}
