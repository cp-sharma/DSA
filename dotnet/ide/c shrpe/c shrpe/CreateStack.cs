namespace c_shrpe
{
    public class CreateStack
    {
        readonly int MAX_SIZE = 101;
        readonly char[] stack;
        int top;

        public CreateStack()
        {
            stack = new char[MAX_SIZE];
            top = -1;
        }
        public bool IsEmpty()
        {
            return top == -1;
        }
        public int TOP()
        {
            if (top != -1)
                return stack[top];
            return -1;
        }

        public bool Push(char data)
        {
            if (top == -1)
            {
                stack[++top] = data;
            }
            else if (top == MAX_SIZE)
            {
                return false;
            }
            else
            {
                stack[++top] = data;

            }
            return true;
        }
        public int Pop()
        {
            int data;
            if (top == -1)
            {
                data = -1;
            }
            else
            {
                data = stack[top--];
            }
            return data;
        }
        public void PrintStack()
        {
            Console.WriteLine("Stack");
            for (int i = 0; i <= top; i++)
            {
                Console.WriteLine(stack[i]);
            }
        }
    }


}
