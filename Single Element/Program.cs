using System;
class NotRepeated
{
    //Main program
    // This program has O(n) time complexity, O(1) space complexity
    public static void Main()
    {
        int[] arr = { 4, 5, 6, 7, 5, 4, 6 };
        int n = arr.Length;
        Console.WriteLine("Element Not Repeated Is " +
            findNotRepeated(arr, n) + "");
    }


    static int findNotRepeated(int[] arr, int arr_size)
    {
        int res = arr[0];

        // Do XOR(^) comparison
        for (int i = 1; i < arr_size; i++)
            res = res ^ arr[i];
        return res;
    }
}