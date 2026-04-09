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

            var key = String.Join(",", count);
            if(sMap.ContainsKey(key))
                sMap[key].Add(s);
            else
                sMap[key] = new List<string>(){s};
        }

        return new(sMap.Values);
    }
}
