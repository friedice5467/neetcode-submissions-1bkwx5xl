public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        var m = matrix.Length;
        var n = matrix[0].Length;

        var l = 0;
        var r = m * n - 1;

        while(l <= r)
        {
            var mid = l + (r - l)/2;
            var val = matrix[mid/n][mid%n];

            if(val > target)
                r = mid - 1;
            else if(val < target)
                l = mid + 1;
            else 
                return true;
        }
        return false;
    }
}
