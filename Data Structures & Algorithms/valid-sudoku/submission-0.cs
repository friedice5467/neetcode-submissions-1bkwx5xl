public class Solution {
    public bool IsValidSudoku(char[][] board) {
         var rows = new Dictionary<int, HashSet<char>>();
        var cols = new Dictionary<int, HashSet<char>>();
        var grid = new Dictionary<(int, int), HashSet<char>>();

        for(int r = 0; r < board.Length; r++)
        {
            for(int c = 0; c < board[r].Length; c++)
            {
                var val = board[r][c] ;
                if(val == '.')
                    continue;

                var square = (r/3, c/3);
                if((rows.ContainsKey(r) && rows[r].Contains(val)) ||
                (cols.ContainsKey(c) && cols[c].Contains(val)) || 
                (grid.ContainsKey(square) && grid[square].Contains(val)))
                {
                    return false;
                }

                if(!rows.ContainsKey(r)) rows[r] = new HashSet<char>();
                if(!cols.ContainsKey(c)) cols[c] = new HashSet<char>();
                if(!grid.ContainsKey(square)) grid[square] = new HashSet<char>();

                rows[r].Add(val);
                cols[c].Add(val);
                grid[square].Add(val);
            }
        }
        return true;
    }
}
