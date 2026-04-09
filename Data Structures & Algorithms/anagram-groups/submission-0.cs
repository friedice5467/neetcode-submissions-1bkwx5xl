public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var answ = new Dictionary<string, List<string>>();

        foreach(var str in strs)
        {
            var count = new int[26];
            foreach(var c in str)
            {
                count[c - 'a']++;
            }
            var key = String.Join(",", count);
            if(!answ.ContainsKey(key))
            {
                answ[key] = new List<string>();
            }
            answ[key].Add(str);
        }
        return new(answ.Values);
    }
}
