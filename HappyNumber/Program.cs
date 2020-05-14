
using System;
class HappyNumber
{

    // Utility method to return  
    // sum of square of digit of n 
    static int numSquareSum(int n)
    {
        int squareSum = 0;
        while (n != 0)
        {
            squareSum += (n % 10) *
                         (n % 10);
            n /= 10;
        }
        return squareSum;
    }

    // method return true if 
    // n is Happy number 
    static bool isHappynumber(int n)
    {
        int slow, fast;

        // initialize slow and 
        // fast by n 
        slow = fast = n;
        do
        {

            // move slow number 
            // by one iteration 
            slow = numSquareSum(slow);

            // move fast number 
            // by two iteration 
            fast = numSquareSum(numSquareSum(fast));

        }
        while (slow != fast);

        // if both number meet at 1, 
        // then return true 
        return (slow == 1);
    }

    // Driver code 
    public static void Main()
    {
        int n = 4;
        if (isHappynumber(n))
            Console.WriteLine(n +
            " is a Happy number");
        else
            Console.WriteLine(n +
            " is not a Happy number");
    }
}