public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var nMap = new Dictionary<int, int>();
        var answ = new int[k];
        foreach(var n in nums)
        {
            if(nMap.ContainsKey(n))
                nMap[n]++;
            else
                nMap[n] = 1;
        }
        var counter = 0;
        while(counter < k)
        {
            var highestVal = int.MinValue;
            var key = 0;
            foreach(var n in nMap)
            {
                if(n.Value > highestVal)
                {
                    highestVal = n.Value;
                    key = n.Key;
                }
            }
            nMap.Remove(key);
            answ[counter] = key;
            counter++;
        }

        return answ;
    }
}
