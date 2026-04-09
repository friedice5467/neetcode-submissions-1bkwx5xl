public class MinStack {
    public Stack<int> stack {get;set;}
    public Stack<int> minStack {get;set;}

    public MinStack() {
        stack = new();
        minStack = new();
    }
    
    public void Push(int val) {
        stack.Push(val);
        val = Math.Min(val, minStack.Count != 0 ? minStack.Peek() : val);
        minStack.Push(val);
    }
    
    public void Pop() {
        stack.Pop();
        minStack.Pop();
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}
