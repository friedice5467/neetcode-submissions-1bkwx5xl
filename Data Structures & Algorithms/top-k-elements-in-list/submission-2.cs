public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var nMap = new Dictionary<int, int>();
        var res = new int[k];
        foreach(var n in nums)
        {
            if(!nMap.ContainsKey(n))
                nMap[n] = 1;
            else
                nMap[n]++;
        }

        for(int i = 0; i < k; i++)
        {
            int highestFreq = int.MinValue;
            var key = 0;
            foreach(var n in nMap)
            {
                if(n.Value > highestFreq){
                    highestFreq = n.Value;
                    key = n.Key;
                }
            }

            res[i] = key;
            nMap.Remove(key);
        }

        return res;
    }
}
