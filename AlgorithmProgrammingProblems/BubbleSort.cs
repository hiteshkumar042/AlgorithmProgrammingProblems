using System;

namespace AlgorithmProgrammingProblems
{
    public class BubbleSort
    {
        public void BubbleSortFn()
        {
            int[] arr = { 15, 31, 24, 12, 45, 30 };
            int temp;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // swap the elements
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            // Print the sorted array
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
