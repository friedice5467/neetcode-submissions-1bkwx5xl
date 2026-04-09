public class Solution {
    public int Trap(int[] height) {
        int maxL = 0;
        int l = 0;
        int maxR = 0;
        int r = height.Length - 1;

        var waterSum = 0;
        
        while(l < r)
        {
            var waterL = maxL - height[l];
            var waterR = maxR - height[r];

            if(waterL > 0)
                waterSum += waterL;

            if(waterR > 0)
                waterSum += waterR;

            maxL = Math.Max(maxL, height[l]);
            maxR = Math.Max(maxR, height[r]);

            if(maxL <= maxR)
                l++;
            else
                r--;
        }

        return waterSum;
    }
}
