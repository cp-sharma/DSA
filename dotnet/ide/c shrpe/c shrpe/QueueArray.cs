namespace c_shrpe
{
    public class QueueArray
    {
        const int MAX_SIZE = 10;
        int[] Queue = new int[MAX_SIZE];
        int front = -1;
        int rear = -1;
        public bool IsEmpty()
        {
            return front == -1 && rear == -1;
        }

        public int Front()
        {
            if (!IsEmpty())
                return Queue[front];
            else
                return -1;
        }

        public bool IsFull()
        {
            if (rear == MAX_SIZE)
                return true;
            else
                return false;
        }

        public void Enqueue(int data)
        {
            if (IsFull())
            {
                return;
            }
            else if (IsEmpty())
            {
                front = 0;
                rear = 0;

            }
            else
            {
                rear++;
            }
            Queue[rear] = data;
        }

        public void Dequeue()
        {
            if (IsEmpty())
            {
                return;
            }
            else if (front == rear)
            {
                front = -1;
                rear = -1;
            }
            else
            {
                front++;
            }
        }
        public void printQueue()
        {
            for (int i = 0; i <= Queue.Length; i++)
            {
                Console.WriteLine(Queue[front]);
            }
        }
    }
}
