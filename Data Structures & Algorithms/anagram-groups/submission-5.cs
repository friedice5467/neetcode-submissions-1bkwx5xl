public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var map = new Dictionary<string, List<string>>();

        foreach(var str in strs)
        {
            var count = new int[26];
            foreach(var c in str)
            {
                count[c - 'a']++;
            }

            var key = string.Join(",", count);
            if(map.ContainsKey(key))
                map[key].Add(str);
            else
                map[key] = new List<string>(){str};
        }

        return map.Values.ToList();
    }
}
