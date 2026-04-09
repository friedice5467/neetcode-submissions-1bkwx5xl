public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        var rows = matrix.Length;
        var cols = matrix[0].Length;

        var left = 0;
        var right = rows * cols - 1;

        while(left <= right)
        {
            var mid = left + (right - left) / 2;
            var val = matrix[mid/cols][mid%cols];

            if(val > target)
                right = mid - 1;
            else if(val < target)
                left = mid + 1;
            else
                return true;
        }
        return false;
    }
}
