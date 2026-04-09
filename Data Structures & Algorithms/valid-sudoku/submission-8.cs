public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var rows = new Dictionary<int, HashSet<char>>();
        var cols = new Dictionary<int, HashSet<char>>();
        var grid = new Dictionary<int, HashSet<char>>(); //key = (r/3) * 3 + (c/3)

            for (int r = 0; r < board.Length; r++) {
            for (int c = 0; c < board[r].Length; c++) {
                char val = board[r][c];
                if (val == '.') continue; 

                if (!rows.ContainsKey(r)) rows[r] = new HashSet<char>();
                if (!cols.ContainsKey(c)) cols[c] = new HashSet<char>();
                int gridKey = (r / 3) * 3 + (c / 3);
                if (!grid.ContainsKey(gridKey)) grid[gridKey] = new HashSet<char>();

                if (!rows[r].Add(val) || !cols[c].Add(val) || !grid[gridKey].Add(val)) {
                    return false;
                }
            }
        }
        return true;
    }
}
