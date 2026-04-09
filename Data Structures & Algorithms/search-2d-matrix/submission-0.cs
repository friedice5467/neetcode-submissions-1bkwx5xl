public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        var l = 0;
        var r = matrix.Length - 1;

        while(l <= r)
        {
            var m = (l + r) / 2;

            var sL = 0;
            var sR = matrix[m].Length - 1;
            var val = 0;
            while(sL <= sR)
            {
                var sM = (sL + sR) / 2;
                val = matrix[m][sM];
                if(val > target)
                    sR = sM - 1;
                else if(val < target)
                    sL = sM + 1;
                else
                    return true;
            }

            if(val > target)
                r = m - 1;
            else
                l = m + 1;
        }

        return false;
    }
}
