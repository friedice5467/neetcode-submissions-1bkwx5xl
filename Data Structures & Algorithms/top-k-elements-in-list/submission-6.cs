public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var numMap = new Dictionary<int, int>();
        var valArr = new List<int>[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            valArr[i] = new List<int>();
        }
        var outputArr = new List<int>(nums.Length);

        for(int i = 0; i < nums.Length; i++)
        {
            if(numMap.ContainsKey(nums[i]))
                numMap[nums[i]]++;
            else
                numMap[nums[i]] = 1;
        }

        foreach(var kvp in numMap)
        {
            valArr[kvp.Value - 1].Add(kvp.Key);
        }

        var target = k;
        for(int i = valArr.Length - 1; i >= 0; i--)
        {
            var vals = valArr[i];
            if(vals.Count == 0)
                continue;

            foreach(var val in vals)
            {
                if(target == 0)
                    break;
                
                outputArr.Add(val);
                target--;
            }
        }

        return outputArr.ToArray();
    }
}
