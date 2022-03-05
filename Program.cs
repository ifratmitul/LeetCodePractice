
var call = new BasicProblems();
int[] arr = { 3, 2, 3 };
int[] arr2 = { 5, 0, 0, 6, 1, 6, 2, 2, 4 };

// call.isBadVersion(5);

string s = JsonSerializer.Serialize(call.twoSum(arr, 6));
Console.WriteLine(s);

