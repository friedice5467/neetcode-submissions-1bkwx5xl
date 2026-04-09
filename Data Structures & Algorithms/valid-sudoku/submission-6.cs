public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var rows = new Dictionary<int, HashSet<char>>();
        var cols = new Dictionary<int, HashSet<char>>();
        var grid = new Dictionary<(int, int), HashSet<char>>();

        for(int i = 0; i < board.Length; i++)
        {
            for(int j = 0; j < board[i].Length; j++)
            {
                var val = board[i][j];
                if(val == '.')
                    continue;

                //check if map contains key 
                var square = (i/3, j/3);
                if((rows.ContainsKey(i) && rows[i].Contains(val)) ||
                    (cols.ContainsKey(j) && cols[j].Contains(val)) ||
                    (grid.ContainsKey(square) && grid[square].Contains(val)))
                        return false;

                if(!rows.ContainsKey(i)) rows[i] = new HashSet<char>();
                if(!cols.ContainsKey(j)) cols[j] = new HashSet<char>();
                if(!grid.ContainsKey(square)) grid[square] = new HashSet<char>();

                rows[i].Add(val);
                cols[j].Add(val);
                grid[square].Add(val);
            }
        }
        return true;
    }
}
