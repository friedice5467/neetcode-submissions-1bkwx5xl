public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var numMap = new Dictionary<int, int>();
        var resultArr = new int[k];

        foreach(var num in nums)
        {
            if(!numMap.TryAdd(num, 1))
                numMap[num]++;
        }

        return numMap.OrderByDescending(x => x.Value).Select(x => x.Key).Take(k).ToArray();
    }
}
