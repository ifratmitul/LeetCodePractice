namespace LeetCode;

public class DoublyLinkedListNode
{
    public DoublyLinkedListNode next { get; set; }
    public DoublyLinkedListNode prev { get; set; }
    public int val;
    public DoublyLinkedListNode(int val)
    {
        this.val = val;
        next = null;
        prev = null;

    }
    
}