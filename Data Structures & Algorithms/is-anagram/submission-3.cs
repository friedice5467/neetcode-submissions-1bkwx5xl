public class Solution {
    public bool IsAnagram(string s, string t) {
        var mapS = new Dictionary<char, int>();
        foreach(char c in s)
        {
            if(!mapS.TryAdd(c, 1))
                mapS[c]++;
        }

        foreach(char c in t)
        {
            if(!mapS.TryGetValue(c, out int val))
                return false;
            else{
                mapS[c]--;
            }
        }

        foreach(var kvp in mapS)
        {
            if(kvp.Value != 0) return false;
        }

        return true;
    }
}
