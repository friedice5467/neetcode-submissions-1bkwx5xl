public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        var rows = matrix.Length;
        var cols = matrix[0].Length;

        var l = 0;
        var r = rows * cols - 1;

        while(l <= r)
        {
            var m = l + (r - l) / 2;
            var val = matrix[m/cols][m%cols];

            if(val > target)
                r = m - 1;
            else if(val < target)
                l = m + 1;
            else
                return true;
        }

        return false;
    }
}
