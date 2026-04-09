public class Solution {
    public int MaxArea(int[] heights) {
        var max = 0;
        int l = 0;
        int r = heights.Length - 1;

        while(l < r)
        {
            var lcd = Math.Min(heights[l], heights[r]);
            var length = r - l;
            max = Math.Max(max, length*lcd);

            if(heights[l] < lcd)
                l++;
            else if(heights[l] > lcd)
                r--;
            else{
                l++;
            }
        }

        return max;
    }
}
