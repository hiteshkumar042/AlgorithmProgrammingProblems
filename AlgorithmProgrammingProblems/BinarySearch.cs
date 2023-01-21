using System;

namespace AlgorithmProgrammingProblems
{
    public class BinarySearch
    {
        public void BinarySearchFn()
        {
            //Initialised an array
            int[] arrayData = { 12, 22, 38, 56, 64, 78, 84, 89, 93, 98 };
            Console.WriteLine("Array Data is  :");
            //Print Array
            foreach (int i in arrayData)
            {
                Console.Write(i + " ");
            }
            //Choose Number to check position
            Console.WriteLine("\nChoose a Number to find the index position");
            int searchItem = Convert.ToInt32(Console.ReadLine());
            int start = 0;
            int end = arrayData.Length - 1; //9

            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (searchItem < arrayData[mid])
                {
                    end = mid - 1;
                }
                else if (searchItem == arrayData[mid])
                {
                    Console.WriteLine("Index Position is : " + mid);
                    break;
                }
                else
                {
                    start = mid + 1;
                }
            }
        }
    }
}
