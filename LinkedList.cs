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

    public void deleteNode(int n)
    {
        LinkedListNode? current = head;
        LinkedListNode? prev = null;
        if (current != null & current.value == n)
        {
            head = current.next;
            return;
        }

        while (current != null && current.value != n)
        {
            prev = current;
            current = current.next;
        }

        if (current == null)
        {
            return;
        }

        head.next = current.next;
    }

    public bool HasCycle()
    {

        LinkedListNode? fast = head;
        LinkedListNode? slow = head;
        while (fast != null && fast.next  != null)
        {
            slow = slow.next;
            fast = fast.next.next;
            if(slow == fast) return true;
        }

        return false;

    }


}