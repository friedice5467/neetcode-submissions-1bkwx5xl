public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var sMap = new Dictionary<string, List<string>>();

        foreach(var str in strs)
        {
            var count = new int[26];
            foreach(var c in str)
            {
                count[c - 'a']++;
            }

            var key = String.Join(',', count);
            if(!sMap.ContainsKey(key))
            {
                sMap[key] = new List<string>();
            }

            sMap[key].Add(str);
        }

        return new(sMap.Values);
    }
}
