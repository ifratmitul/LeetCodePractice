using System.Text.RegularExpressions;
using System.Text;

namespace LeetCodePractice;
public class LeetEasy
{
     public int LengthOfLastWord(string s)
     {
          int len = 0;
          string last = s.Trim().Split(' ').LastOrDefault().Trim();
          len = last.Length;
          return len;
     }

     public IList<IList<int>> ShiftGrid(int[][] grid, int k)
     {
          IList<IList<int>> res = new List<IList<int>>();
          int n = grid.Length;
          int m = grid[0].Length;

          while (k > 0)
          {
               for (int i = 0; i < n; i++)
               {
                    for (int j = 1; j < m; j++)
                    {
                         res[i][j] = grid[i][j - 1];
                    }
               }

               for (int i = 1; i < n; i++)
               {
                    res[i][0] = grid[i - 1][m - 1];
               }

               res[0][0] = grid[n - 1][m - 1];

               k--;
          }

          return res;
     }

     public int[][] SpiralMatrix(int n)
     {
          int[][] res = new int[n][];
          int top = 0, bottom = n - 1, left = 0, right = n - 1;
          int direction = 1;
          int j = 1;
          int k = 1;

          while (k <= n * n)
          {
               if (direction == 1)
               //left to right
               {
                    for (int i = left; i <= right; ++i)
                    {
                         if (res[top] == null) res[top] = new int[n];
                         res[top][i] = j;
                         j++;
                    }
                    ++top;
                    direction = 2;
               }

               else if (direction == 2)
               {
                    //top to bottom
                    for (int i = top; i <= bottom; ++i)
                    {
                         if (res[i] == null) res[i] = new int[n];
                         res[i][right] = j;
                         Console.WriteLine(j);
                         j++;
                    }
                    --right;
                    direction = 3;
               }
               else if (direction == 3)
               {
                    //right to left
                    for (int i = right; i >= left; --i)
                    {
                         if (res[bottom] == null) res[bottom] = new int[n];
                         res[bottom][i] = j;
                         j++;
                    }
                    --bottom;
                    direction = 4;
               }
               else
               {
                    //bottom to up
                    for (int i = bottom; i >= top; --i)
                    {
                         if (res[i] == null) res[i] = new int[n];
                         res[i][left] = j;
                         j++;
                    }
                    ++left;
                    direction = 1;
               }

               k++;



          }

          Console.WriteLine(JsonSerializer.Serialize(res));

          return res;
     }


     public bool IsAnagram(string s, string t)
     {

          if (s.Length != t.Length) return false;
          int[] charCount = new int[26];

          foreach (char c in s)
          {
               charCount[c - 'a']++;
          }

          foreach (char c in t)
          {
               charCount[c - 'a']--;
          }
          Console.WriteLine("Hellooo");
          Console.WriteLine(JsonSerializer.Serialize(charCount));

          for (int i = 0; i < charCount.Length; i++)
          {
               if (charCount[i] != 0) return false;
          }

          return true;


     }


     public bool BackspaceCompare(string s, string t)
     {

          Stack<char> s1 = new Stack<char>();
          Stack<char> s2 = new Stack<char>();


          foreach (char item in s)
          {
               if (item != '#') s1.Push(item);
               if (item == '#') s1.Pop();

          }

          foreach (var item in t)
          {
               if (item != '#') s2.Push(item);
               if (item == '#') s2.Pop();
          }

          if (s1.Count != s2.Count) return false;
          if (s1.Count == 0 && s2.Count == 0) return true;

          string str1 = "";
          string str2 = "";


          while (s1.Count > 0 && s2.Count > 0)
          {
               str1 = string.Concat(str1, s1.Pop());
               str2 = string.Concat(str2, s2.Pop());
          }

          return String.Equals(str1, str2);
     }


     public int[] SortArrayByParity(int[] nums)
     {
          if (nums.Length <= 1) return nums;


          List<int> res = new List<int>();
          List<int> odd = new List<int>();
          List<int> even = new List<int>();

          int len = nums.Length - 1;

          for (int i = 0; i <= len; i++)
          {

               if (nums[i] == 0)
               {
                    even.Add(0);
               }
               else if (nums[i] % 2 == 0)
               {
                    even.Add(nums[i]);
               }
               else
               {
                    odd.Add(nums[i]);
               }


          }

          res.AddRange(even);
          res.AddRange(odd);

          return res.ToArray();

     }


     public int[][] Transpose(int[][] matrix)
     {
          int row = matrix.Length;
          int col = matrix[0].Length;
          int[][] transpose = new int[col][];

          //initialize array
          for (int i = 0; i < col; i++)
          {
               transpose[i] = new int[row];
          }

          for (int r = 0; r < matrix.Length; r++)
          {
               for (int c = 0; c < matrix[r].Length; c++)
               {
                    transpose[c][r] = matrix[r][c];
               }
          }

          return transpose;
     }

     public void Merge(int[] nums1, int m, int[] nums2, int n)
     {
          int size = m + n;
          // int[] res = new int[size];
          // nums1 = nums1.Where(item => item > 0).ToArray();
          // nums2 = nums2.Where(item => item > 0).ToArray();

          foreach (var item in nums2)
          {
               int index = Array.IndexOf(nums1, 0);
               Console.WriteLine("Index => {0}", index);

               if (index > -1)
               {
                    nums1[index] = item;
               }
          }
          Array.Sort(nums1);

          Console.WriteLine(JsonSerializer.Serialize(nums1));
          // Console.WriteLine(JsonSerializer.Serialize(nums2));


     }

     public bool IsValidSudoku(char[][] board)
     {
          bool col = false, row = false, grid = false;

          //row iteration
          for (int r = 0; r < board.Length; r++)
          {
               Console.Write("Row => ");
               board[r] = board[r].Where(item => !item.Equals(".")).ToArray();
               Console.WriteLine(JsonSerializer.Serialize(board[r]));
          }
          //column iteration



          return col && row && grid;
     }

     public int RemovePalindromeSub(string s)
     {
          char[] arr = s.ToCharArray();
          Array.Reverse(arr);
          string newString = string.Join("", arr);
          if (s.Equals(newString))
          {
               return 1;
          }
          return 2;
     }

     public bool IsPalindrome(string s)
     {
          List<string> str = new();
         
          for (int i = 0; i < s.Length; i++)
          {
               if(new Regex(@"^[a-zA-Z]+$").IsMatch(s[i].ToString()))
               {
                    System.Console.WriteLine(s[i]);
                    str.Add(s[i].ToString());
               }
               
          }

          string s1 = string.Join("",str).ToLower();
          str.Reverse();
          string s2 = string.Join("",str).ToLower();
          if(s1.Equals(s2)) return true;


          return false;
     }

}
