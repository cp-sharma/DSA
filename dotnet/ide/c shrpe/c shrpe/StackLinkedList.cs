namespace c_shrpe
{
    public class StactNode
    {
        public int data;
        public StactNode next;
    }
    public class StackLinkedList
    {
        public StactNode Top;
        public StackLinkedList()
        {
            Top = null;
        }

        public bool IsEmpty()
        {
            return Top != null;
        }

        public int TOP()
        {
            if (Top != null)
                return Top.data;
            else
                return -1;
        }

        public bool PUSH(int data)
        {
            StactNode stactNode = new StactNode();
            stactNode.data = data;
            stactNode.next = null;
            if (Top == null)
            {
                Top = stactNode;
                return true;
            }
            else
            {
                stactNode.next = Top;
                Top = stactNode;
                return true;
            }
            return false;
        }

        public bool POP()
        {
            StactNode temp = null;
            if (Top != null)
            {
                temp = Top;
                Top = Top.next;
                return true;
            }
            return false;
        }

        public void PrintStack()
        {
            StactNode temp = Top;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }

    }
}
