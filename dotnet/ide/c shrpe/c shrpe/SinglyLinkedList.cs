namespace c_shrpe
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int data, Node next)
        {
            this.data = data;
            this.next = next;
        }
    }
    public class SinglyLinkedList
    {

        public Node head;
        public SinglyLinkedList()
        {
            head = null;
        }

    }
}
