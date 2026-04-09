public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var sMap = new Dictionary<string, List<string>>();

        foreach(var s in strs)
        {
            var count = new int[26];
            foreach(var c in s)
            {
                count[c - 'a']++;
            } 

            var key = string.Join(",", count);
            if(!sMap.ContainsKey(key))
            {
                sMap[key] = new List<string>();
            }
            sMap[key].Add(s);
        }

        return new (sMap.Values);
    }
}
