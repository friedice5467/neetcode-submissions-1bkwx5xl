public class Solution {  
    public List<string> GenerateParenthesis(int n) {
        var res = new List<string>();
        Backtrack(n, 0, 0, "", res);
        return res;
    }

    public void Backtrack(int n, int open, int close, string current, List<string> res)
    {
        if(n == open && open == close)
        {
            res.Add(current);
            return;
        }

        if(open < n)
        {
            Backtrack(n, open + 1, close, current + "(", res);
        }
        if(close < open)
        {
            Backtrack(n, open, close + 1, current + ")", res);
        }
    }
}
