public class Solution {
    public int EvalRPN(string[] tokens) {
        var stack = new Stack<int>();
        var ops = new HashSet<string>(){"+", "-", "/", "*"};

        foreach(var t in tokens)
        {
            if(!ops.Contains(t))
            {
                stack.Push(int.Parse(t));
            }
            else if(t == "+")
            {
                stack.Push(stack.Pop() + stack.Pop());
            }
            else if(t == "-")
            {
                int a = stack.Pop();
                int b = stack.Pop();
                stack.Push(b - a);
            }
            else if(t == "*")
            {
                stack.Push(stack.Pop() * stack.Pop());
            }
            else if(t == "/")
            {
                int a = stack.Pop();
                int b = stack.Pop();
                stack.Push(b / a);
            }
        }
        
    return stack.Pop();
    }

}
