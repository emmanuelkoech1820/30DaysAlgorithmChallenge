using System;

namespace MaximumSubSubArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { -2, -3, 4, -1, 2, -1, -5, -3 };


            SubMaxArray(arr);
        }

        static void SubMaxArray(int[] arr)
        {
            int size = arr.Length;
            int max_so_far = int.MinValue,
       max_ending_here = 0, start = 0,
       end = 0, s = 0;

            for (int i = 0; i < size; i++)
            {
                max_ending_here += arr[i];

                if (max_so_far < max_ending_here)
                {
                    max_so_far = max_ending_here;
                    start = s;
                    end = i;
                }

                if (max_ending_here < 0)
                {
                    max_ending_here = 0;
                    s = i + 1;
                }
            }
            Console.WriteLine("Maximum contiguous " +
                             "sum is " + max_so_far);
            Console.WriteLine("Starting index " +
                                          start);
            Console.WriteLine("Ending index " +
                                          end);
        }

    }
}


