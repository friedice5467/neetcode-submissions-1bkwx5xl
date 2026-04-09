public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s.Length == 0) return 0;
        var cSet = new HashSet<char>();
        var maxLength = 0;
        var winStart = 0;
        for (int winEnd = 0; winEnd < s.Length; winEnd++) {
        while (cSet.Contains(s[winEnd])) {
            cSet.Remove(s[winStart]);
            winStart++;
        }

        cSet.Add(s[winEnd]);
        maxLength = Math.Max(maxLength, winEnd - winStart + 1);
    }

        return maxLength;
    }
}
