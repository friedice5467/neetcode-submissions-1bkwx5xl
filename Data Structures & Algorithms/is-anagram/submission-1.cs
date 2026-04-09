public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        var cMap = new Dictionary<char, int>();
        foreach(var c in s)
        {
            if(!cMap.ContainsKey(c))
                cMap[c] = 1;
            else
                cMap[c]++;
        }

        foreach(var c in t)
        {
            if(!cMap.ContainsKey(c))
                return false;
            else
            {
                if(cMap[c] > 0)
                    cMap[c]--;
                else
                    return false;
            }
        }

        return true;
    }
}
