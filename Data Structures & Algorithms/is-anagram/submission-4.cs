public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length) return false;

        var sMap = new Dictionary<char, int>();
        var tMap = new Dictionary<char, int>();

        foreach(var c in s)
        {
            if(!sMap.TryAdd(c, 1))
                sMap[c]++;
        }

        foreach(var c in t)
        {
            if(!tMap.TryAdd(c, 1))
                tMap[c]++;
        }

        foreach(var kvp in sMap)
        {
            if(!tMap.TryGetValue(kvp.Key, out int value))
                return false;

            if(value != sMap[kvp.Key])
                return false;
        }

        return true;
    }
}
