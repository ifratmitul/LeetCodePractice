namespace LeetCode
{
    public class BasicProblems
    {
        public int RemoveDuplicates(int[] num) {
            int i , j = 0;

            for(i =1; i < num.Length; i++) {
                if(num[i] != num[j]){
                    num[++j] = num[i];
                }
            }

            return j+1;
        }
    }
}