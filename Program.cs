
var call = new BasicProblems();
int[] arr = { -1, 0, 1, 2, -1, -4 };
int[] arr2 = { 5, 0, 0, 6, 1, 6, 2, 2, 4 };
// call.isBadVersion(5);

string s = JsonSerializer.Serialize(call.ThreeSum(arr));
Console.WriteLine(s);

