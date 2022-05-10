namespace LeetCodePractice;
public class CodeChef
{

    public void sixFriends() {
        int len = Int32.Parse(Console.ReadLine());

        for(int i = 0; i< len; i++)
        {
            string[] arr = Console.ReadLine().Split(' ');
            int x = Int32.Parse(arr[0]);
            int y = Int32.Parse(arr[1]);

            int costOfDoubleRoom = x * 3;
            int costOfTrippleRoom = y * 2;

            /*
             - 6 freinds 
             double room then x * 3;
             triple room then y * 2;
            
            */

            if(costOfDoubleRoom < costOfTrippleRoom) Console.WriteLine(costOfDoubleRoom);
            else Console.WriteLine (costOfTrippleRoom);

        }
    }

}