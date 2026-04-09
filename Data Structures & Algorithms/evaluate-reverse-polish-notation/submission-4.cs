public class Solution {
    public int EvalRPN(string[] tokens) {
        var stack = new Stack<int>();
        var sSet = new HashSet<string>(){"+", "-", "/", "*"};

        foreach(var t in tokens)
        {
            if(!sSet.Contains(t))
            {
                stack.Push(int.Parse(t));
            }
            else if(t == "+")
            {
                stack.Push(stack.Pop() + stack.Pop());
            }
            else if(t == "-")
            {
                var a = stack.Pop();
                var b = stack.Pop();

                stack.Push(b - a);
            }
            else if(t == "*")
            {
                stack.Push(stack.Pop() * stack.Pop());
            }
            else if(t == "/")
            {
                var a = stack.Pop();
                var b = stack.Pop();
                stack.Push(b/a);
            }
        }

        return stack.Pop();
    }
}
