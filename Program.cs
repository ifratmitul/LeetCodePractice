
var call = new BasicProblems(new SearchAlgo());
int[] arr = { 4,9,5 };
int[] arr2 = { 2,7,4,1,8,1 };
char[] Arr3 = {'k', 'f', 'j','m', 'a'};
// call.isBadVersion(5);

/*string s = JsonSerializer.Serialize(call.Intersect(arr, arr2));
call.IsPerfectSquare(16);
call.IsPerfectSquare(14);
Console.WriteLine(s);*/

call.NextGreatestLetter(Arr3, 'c');
call.LastStoneWeight(arr2);

DoublyLinkedList linkedList = new DoublyLinkedList();
linkedList.AddtoFront(5);
linkedList.AddtoFront(1);
linkedList.AddtoFront(2);
linkedList.AddtoFront(3);
linkedList.AddtoFront(4);

linkedList.PrintList();

linkedList.removeSpecificNode(1);
linkedList.PrintList();


