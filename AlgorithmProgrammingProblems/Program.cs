using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgrammingProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\nWelcome to Algorithm Problems\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("1.Anagram.");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1: //Anagram Detection 
                    Anagram anagram = new Anagram();
                    anagram.CheckAnagram();
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
