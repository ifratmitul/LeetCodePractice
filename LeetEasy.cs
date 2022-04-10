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
}
