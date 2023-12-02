using c_shrpe;
public class Program
{

    public static void Main()
    {


        QueueArray queueArray = new QueueArray();


        Console.WriteLine(queueArray.IsFull());
        Console.WriteLine(queueArray.IsEmpty());

        queueArray.Enqueue(12);
        queueArray.Enqueue(121);
        Console.WriteLine("Enqueue");
        queueArray.printQueue();
        queueArray.Enqueue(2);
        queueArray.Enqueue(132);
        queueArray.Enqueue(344);
        Console.WriteLine("Enqueue");
        queueArray.printQueue();

        queueArray.Dequeue();
        queueArray.Dequeue();
        Console.WriteLine("DEqueue");
        queueArray.printQueue();


        //BalanceParenthesis balance = new BalanceParenthesis();
        //Console.WriteLine(balance.BalanceCheck("{[[}}"));


        Program program = new Program();

        //ReverseStringUsingStack stack = new ReverseStringUsingStack();
        //stack.ReverseString("Hellodsfasdfsdf");

        //StackLinkedList stackLinkedList = new StackLinkedList();
        //Console.WriteLine("Stack");
        //stackLinkedList.PrintStack();
        //Console.WriteLine(stackLinkedList.IsEmpty());
        //Console.WriteLine(stackLinkedList.TOP());
        //Console.WriteLine(stackLinkedList.PUSH(4));
        //Console.WriteLine(stackLinkedList.PUSH(12));
        //Console.WriteLine(stackLinkedList.PUSH(63));
        //Console.WriteLine(stackLinkedList.PUSH(72));
        //Console.WriteLine(stackLinkedList.PUSH(83));
        //stackLinkedList.PrintStack();
        //Console.WriteLine(stackLinkedList.POP());
        //Console.WriteLine(stackLinkedList.POP());
        //Console.WriteLine(stackLinkedList.POP());
        //stackLinkedList.PrintStack();

        //CreateStack stack = new CreateStack();
        //Console.WriteLine("TOP: " + stack.TOP());
        //Console.WriteLine("IsEmpty: " + stack.IsEmpty());

        //stack.Push(12);
        //stack.Push(13);
        //stack.Push(14);
        //stack.Push(15);
        //Console.WriteLine("TOP: " + stack.TOP());
        //Console.WriteLine("IsEmpty: " + stack.IsEmpty());
        //stack.PrintStack();
        SinglyLinkedList singlyLinkedList = new SinglyLinkedList();
        Node head = singlyLinkedList.head;
        Node temp = head;
        temp = program.Insert(1, 1, temp);
        temp = program.Insert(2, 2, temp);
        temp = program.Insert(3, 3, temp);
        temp = program.Insert(4, 4, temp);
        head = program.Insert(44, 2, temp);
        program.PrintList(head);
        Console.WriteLine("Reverse recursive:");
        Node t = head;
        program.reversePrintRecursive(t);

        program.PrintList(temp);
        Console.WriteLine("Print recursive:");
        program.PrintRecursive(temp);
        temp = program.reverselist(temp);
        Console.WriteLine("Reverse:");
        program.PrintList(temp);


        // temp = program.DeleteNode(1, temp);
        //temp = program.DeleteNode(3, temp);
        //temp = program.DeleteNode(5, temp);

        //program.PrintList(temp);

    }
    Node reverseLinkedListRecursive(Node head)
    {
        Node p = head;
        if (p.next == null)
        {
            head = p;
            return head;
        }
        reverseLinkedListRecursive(p.next);
        Node q = p.next;
        q.next = p;
        p.next = null;
        return head;
    }
    void reversePrintRecursive(Node temp)
    {
        if (temp == null) return;
        reversePrintRecursive(temp.next);
        Console.WriteLine(temp.data);

    }
    void PrintRecursive(Node temp)
    {
        if (temp == null) return;
        Console.WriteLine(temp.data);
        PrintRecursive(temp.next);
    }

    Node reverselist(Node head)
    {
        Node curr = head;
        Node nxt, pre = null;
        if (curr != null)
        {
            while (curr != null)
            {
                nxt = curr.next;
                curr.next = pre;
                pre = curr;
                curr = nxt;
            }
            head = pre;
        }
        return head;
    }
    Node DeleteNode(int index, Node head)
    {
        Node temp = null;
        Node curr = head;
        Node pre = null;
        int k = 1;
        if (index == 1)
        {
            temp = head.next;
            head = temp;

        }
        else
        {
            while (curr != null && k < index)
            {
                k++;
                pre = curr;
                curr = curr.next;
            }
            pre.next = curr.next;
            curr.next = null;
        }

        return head;
    }
    void PrintList(Node temp)
    {
        while (temp != null)
        {
            Console.WriteLine(temp.data);
            temp = temp.next;
        }
    }
    Node Insert(int data, int index, Node head)
    {
        Node node = new Node(data, null);
        Node curr = head;
        Node pre = null;
        int k = 1;
        if (index == 1)
        {
            node.next = curr;
            head = node;
        }
        else
        {
            while (curr != null && k < index)
            {
                k++;
                pre = curr;
                curr = curr.next;
            }
            pre.next = node;
            node.next = curr;
        }
        return head;
    }
}

