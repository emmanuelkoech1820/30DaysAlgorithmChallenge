using System;

namespace MoveAllZerosToEndInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 9, 8, 4, 0, 0, 2, 7, 0, 6, 0, 9 };
            int n = arr.Length;
            PushZerosToEnd(arr, n);
            Console.WriteLine("Array after pushing all zeros to the back: ");
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
        }


        static void PushZerosToEnd(int[] arr, int n)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] != 0)
                    arr[count++] = arr[i];
            }
            while (count < n)
                arr[count++] = 0;
        }
    }
}
