namespace c_shrpe
{
    public class node
    {
        public int data;
        public Node prev;
        public Node next;
        public node(int data)
        {
            this.data = data;
            this.prev = null;
            this.next = null;
        }
    }
    public class DoublyLinkedList
    {
        public node node1;
        public DoublyLinkedList()
        {
            this.node1 = null;
        }
    }
}
