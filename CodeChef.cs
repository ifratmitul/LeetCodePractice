namespace LeetCodePractice;
public class CodeChef
{

    public void sixFriends()
    {
        int len = Int32.Parse(Console.ReadLine());

        for (int i = 0; i < len; i++)
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

            if (costOfDoubleRoom < costOfTrippleRoom) Console.WriteLine(costOfDoubleRoom);
            else Console.WriteLine(costOfTrippleRoom);

        }
    }

    public void oddEvenFibonacci()
    {
        int t = Int32.Parse(Console.ReadLine());
       
        for (int i = 0; i < t; i++)
        {
             int a = 0, b = 1;
            string[] arr = Console.ReadLine().Split(' ');
            int n = Int32.Parse(arr[0]);
            int m = Int32.Parse(arr[1]);
            int odd = 0;
            int even = 0;

            while (a <= m)
            {
                if (a >= n)
                {
                    //Console.WriteLine("Fibo => " + a);
                    if (a == 0) ++even;
                    else if (a % 2 == 0) ++even;
                    else ++odd;
                }
                int c = a + b;
                a = b;
                b = c;
            }
            Console.WriteLine("Case " + (i+1) + ":");
            Console.WriteLine("Odd " + odd);
            Console.WriteLine("Even " + even);

        }
    }

    public void PalindromRange()
    {


        /*Time complexity O(n^2) as we have to run nested loop except the one for input, 
        then we find the palindrom number by reversing the current number in iteration
        then if current number in iteration and its reverse is the same then its a palindrom 
        and we increment the count by one
         */
        int t = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < t; i++)
        {
            string[] arr = Console.ReadLine().Split(' ');
            int min = Int32.Parse(arr[0]);
            int max = Int32.Parse(arr[1]);
            int count = 0;
            int num1 = 0;
            int num2 = 0;
            for (int j = min; j <= max; j++)
            {
                num1 = j;
                num2 = 0;
                while (num1 != 0)
                {
                    int rem = num1 % 10;
                    num1 /= 10;
                    num2 = num2 * 10 + rem;
                }

                if (j == num2)
                {
                    count++;
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine(count);
        }

    }

}