namespace c_shrpe
{
    public class ReverseStringUsingStack
    {
        public void ReverseString(string str)
        {
            Char[] ch = str.ToCharArray();
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < ch.Length; i++)
            {
                stack.Push(ch[i]);
            }
            for (int i = 0; i < ch.Length; i++)
            {
                ch[i] = stack.Pop();
            }
            Console.WriteLine(new string(ch));
        }
    }
}