public class Solution {  
    public List<string> GenerateParenthesis(int n) {
        var list = new List<string>();
        Backtrack(n, 0, 0, "", list);
        return list;
    }

    public void Backtrack(int n, int open, int close, string current, List<string> list)
    {
        if(open == n && open == close)
        {
            list.Add(current);
            return;
        }

        if(open < n)
        {
            Backtrack(n, open + 1, close, current + "(", list);
        }

        if(close < open)
        {
            Backtrack(n, open, close + 1, current + ")", list);
        }
    }
}
