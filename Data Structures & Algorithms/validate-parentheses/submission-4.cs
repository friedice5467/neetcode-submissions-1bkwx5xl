public class Solution {
    public bool IsValid(string s) {
        if(s.Length %2 != 0) return false;

        var stack = new Stack<char>();
        var sMap = new Dictionary<char, char>()
        {
            {'}', '{'},
            {']', '['},
            {')', '('}
        };

        foreach(var c in s)
        {
            if(!sMap.ContainsKey(c))
                stack.Push(c);
            else{
                if(stack.Count != 0 && sMap[c] != stack.Pop())
                    return false;
            }
        }

        return stack.Count == 0;
    }
}
