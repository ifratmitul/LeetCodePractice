namespace LeetCode;

public class LinkedListNode
{
    public int value;

    // public LinkedListNode next;
     public LinkedListNode? next { set; get; }

    public LinkedListNode(int val)
    {
        this.value = val;
        next = null;
    }
}