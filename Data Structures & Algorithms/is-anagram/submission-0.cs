public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;

        if(s.Length == 0)
            return true;

        var sDict = new Dictionary<char, int>();

        foreach(var c in s)
        {
            if(!sDict.TryAdd(c, 1))
                sDict[c]++;
        }

        foreach(var c in t)
        {
            if(sDict.ContainsKey(c))
            {
                var val = sDict[c];
                if(val == 0)
                    return false;

                sDict[c]--;
            }
            else{
                return false;
            }
        }

        return true;
    }
}
