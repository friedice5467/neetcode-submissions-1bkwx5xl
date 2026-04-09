public class Solution {
    public int MaxArea(int[] heights) {
        //area = l * h;
        //l = distance of 2 pointers
        //h = lowest pointer between l and r

        var l = 0;
        var r = heights.Length - 1;
        var maxArea = 0;
        while(l < r)
        {
            var lowestH = Math.Min(heights[l], heights[r]);
            var length = Math.Abs(l - r);
            var curArea = lowestH * length;
            maxArea = Math.Max(maxArea, curArea);

            if(heights[l] <= heights[r])
                l++;
            else
                r--;
        }
        return maxArea;
    }
}
