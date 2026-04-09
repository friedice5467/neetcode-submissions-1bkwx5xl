public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var nMap = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            var val = nums[i];
            if(nMap.ContainsKey(val))
                nMap[val]++;
            else
                nMap[val] = 1;
        }

        List<int>[] buckets = new List<int>[nums.Length + 1];
        foreach(var pair in nMap)
        {
            var freq = pair.Value;
            if(buckets[freq] == null)
                buckets[freq] = new();

            buckets[freq].Add(pair.Key);
        }

        var topK = new List<int>();
        for(int i = buckets.Length - 1; i >= 0 && topK.Count < k; i--)
        {
            if(buckets[i] != null)
                topK.AddRange(buckets[i]);

            if(topK.Count > k)
                return topK.GetRange(0, k).ToArray();
        }
        return topK.ToArray();
    }
}
