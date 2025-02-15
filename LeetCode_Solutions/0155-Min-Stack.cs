namespace LeetCode_Solutions;

public class MinStack 
{
    private Stack<int> stack;
    private Stack<int> minStack;
    private int min;

    public MinStack() 
    {
        stack = new Stack<int>();
        minStack = new Stack<int>();
    }

    public void Push(int val) 
    {
        if (stack.Count == 0) 
        {
            min = val;
        }
        
        stack.Push(val);
        min = Math.Min(val, min);
        minStack.Push(min);
    }

    public void Pop() 
    {
        stack.Pop();
        minStack.Pop();

        if (minStack.Count > 0)
        {
            min = minStack.Peek();
        }
    }

    public int Top() 
    {
        return stack.Peek();
    }

    public int GetMin() 
    {
        return min;
    }
}