namespace c_shrpe
{
    public class QNode
    {
        public int data;
        public QNode next;
    }
    public class QueueLinkedList
    {
        QNode head;
        QNode rear = null;
        QNode front = null;

        public QueueLinkedList()
        {
            head = null;
        }

        public bool IsEmpty()
        {
            if (front == null && rear == null)
            {
                return true;
            }
            return false;
        }
        public void Enqueue(int data)
        {
            QNode temp = new QNode();
            temp.data = data;
            temp.next = null;
            if (rear == null && front == null)
            {
                front = rear = temp;
                return;
            }
            rear.next = temp;
            rear = temp;
        }
        public void Dequeue()
        {
            if (front == null)
                return;
            if (front == rear)
            {
                front = rear = null;
            }
            else
            {
                front = front.next;
            }
        }
    }
}
