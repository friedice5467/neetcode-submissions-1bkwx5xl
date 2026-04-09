public class Solution {
    public int[][] Merge(int[][] intervals) {
        var res = new List<int[]>();
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        var prev = intervals[0];
        for(int i = 1; i < intervals.Length; i++)
        {
            var cur = intervals[i];
            if(prev[1] >= cur[0]) //if is interval
            {
                prev[1] = Math.Max(prev[1], cur[1]);
            }
            else{
                res.Add(prev);
                prev = cur;
            }
        }
        res.Add(prev);
        return res.ToArray();
    }
}
