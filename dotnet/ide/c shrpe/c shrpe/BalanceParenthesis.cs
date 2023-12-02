namespace c_shrpe
{
    public class BalanceParenthesis
    {
        public bool BalanceCheck(string exp)
        {
            int size = exp.Length;
            char[] ch = exp.ToCharArray();
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < size; i++)
            {
                if (ch[i] == '(' || ch[i] == '[' || ch[i] == '{')
                {
                    stack.Push(ch[i]);
                }
                else if (ch[i] == ')' || ch[i] == ']' || ch[i] == '}')
                {
                    if (stack.Count < 0)
                    {
                        return false;
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
            }
            return stack.Count == -1 ? true : false;
        }
    }
}
