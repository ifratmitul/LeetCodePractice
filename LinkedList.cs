namespace LeetCode;

public class LinkedList
{
    public LinkedListNode head;

    public void AddtoFront(int n)
    {
        LinkedListNode newNode = new LinkedListNode(n);
        newNode.next = head;
        head = newNode;
    }

    public LinkedListNode removeNode()
    {
        //remove front he front
        if (head == null) return null;

        LinkedListNode removeNode = head;
        head = head.next;
        removeNode.next = null;

        return removeNode;
    }

    public void PrintList()
    {
        LinkedListNode current = head;
        Console.WriteLine("Head => ");
        while (current != null)
        {
            Console.WriteLine(current.value);
            current = current.next;
        }
        Console.WriteLine("Finished");
    }
}