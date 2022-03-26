
var call = new BasicProblems(new SearchAlgo());
int[] arr = { 4,9,5 };
int[] arr2 = { 9,4,9,8,4 };
// call.isBadVersion(5);

string s = JsonSerializer.Serialize(call.Intersect(arr, arr2));
Console.WriteLine(s);

