public class ValidParenthesis
{
    public ValidParenthesis()
    {
        
    }

    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        foreach (char c in s)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }
            else if (c == ')' && stack.Count > 0 && stack.Peek() == '(')
            {
                stack.Pop();
            }
            else if (c == '}' && stack.Count > 0 && stack.Peek() == '{')
            {
                stack.Pop();
            }
            else if (c == ']' && stack.Count > 0 && stack.Peek() == '[')
            {
                stack.Pop();
            }
            else
            {
                return false;
            }
        }

        return stack.Count == 0;
    }
}