using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgrammingProblems
{
    public class Anagram
    {
        public void CheckAnagram()
        {
            Console.WriteLine("Enter teh first word/number : ");
            string firstWord = Console.ReadLine();
            Console.WriteLine("Enter teh first word/number : ");
            string secondWord = Console.ReadLine();
            //storing every single character in char array
            char[] fwstr = firstWord.ToLower().ToCharArray();
            char[] lwstr = secondWord.ToLower().ToCharArray();
            //sorting array
            Array.Sort(fwstr);
            Array.Sort(lwstr);
            //converting array to string
            if(new String(fwstr)==new string(lwstr))
            {
                Console.WriteLine("It is a Anagram");
            }
            else
            {
                Console.WriteLine("It's not a Anagram");
            }
        }
        
    }
}
