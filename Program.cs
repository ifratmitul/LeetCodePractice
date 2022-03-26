
var call = new BasicProblems(new SearchAlgo());
int[] arr = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
int[] arr2 = { 5, 0, 0, 6, 1, 6, 2, 2, 4 };
// call.isBadVersion(5);

string s = JsonSerializer.Serialize(call.PlusOne(arr));
Console.WriteLine(s);

