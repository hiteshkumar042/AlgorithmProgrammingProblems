using System;

namespace AlgorithmProgrammingProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\nWelcome to Algorithm Problems\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("1.Anagram.\n2.Binary Search.\n3. Bubble Sort.\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1: //Anagram Detection 
                    Anagram anagram = new Anagram();
                    anagram.CheckAnagram();
                    break;
                case 2: //Binary Search 
                    BinarySearch binarySearch = new BinarySearch();
                    binarySearch.BinarySearchFn();
                    break;
                case 3: //Bubble Sort 
                    BubbleSort bubbleSort = new BubbleSort();
                    bubbleSort.BubbleSortFn();
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
