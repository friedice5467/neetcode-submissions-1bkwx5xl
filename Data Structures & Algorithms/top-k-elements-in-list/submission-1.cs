public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var nMap = new Dictionary<int, int>();
        var res = new int[k];

        foreach(var n in nums)
        {
            if(nMap.ContainsKey(n))
                nMap[n]++;
            else
                nMap[n] = 1;
        }

        for(int i = 0; i < k; i++)
        {
            var freq = 0;
            var key = 0;
            foreach(var n in nMap)
            {
                if(n.Value > freq)
                {
                    freq = n.Value;
                    key = n.Key;
                }
            }
            res[i] = key;
            nMap.Remove(key);
        }

        return res;
    }
}
