namespace LeetCode;

public class DoublyLinkedList
{
    public DoublyLinkedListNode head;
    public DoublyLinkedListNode tail;

    public void AddtoFront(int n)
    {
        DoublyLinkedListNode newNode = new DoublyLinkedListNode(n);

        if (head == null)
        {
            tail = newNode;
        }
        else
        {
            head.prev = newNode;
        }
        newNode.next = head;
        head = newNode;
    }

    public void AddtoTail(int n)
    {
        DoublyLinkedListNode newNode = new DoublyLinkedListNode(n);
        if (tail == null)
        {
            head = newNode;
        }
        else
        {
            tail.prev = newNode;
        }

        newNode.next = tail;
        tail = newNode;
    }

    public DoublyLinkedListNode removeFromFront()
    {
        if (head == null) return null;
        
        var removeNode = head;
        
        if (head.next == null)
        {
            tail = null;
        }
        else
        {
            head.next.prev = null;
        }
        head = head.next;
        
        removeNode.next = null;
        removeNode.prev = null;

        return removeNode;
    }

    public void removeSpecificNode(int n)
    {
        DoublyLinkedListNode current = head;
        DoublyLinkedListNode previousNode = null;

        if(current != null && current.val == n) {
            head = current.next;
            return;
        }
        while (current != null && current.val != n)
        {
            previousNode = current;
            current = current.next;
        }

        if(current == null) return ;
        previousNode.next = current.next;
        current.next.prev = previousNode;

    }
    

    public void PrintList()
    {
        DoublyLinkedListNode current = head;
        Console.WriteLine("Head => ");
        while (current != null)
        {
            Console.WriteLine(current.val);
            current = current.next;
        }
    }

    public void printReverse()
    {
        DoublyLinkedListNode current = tail;
        Console.WriteLine("Tail => ");
        while (current != null)
        {
            Console.WriteLine(current.val + " -> ");
            current = current.prev;
        }
    }
}