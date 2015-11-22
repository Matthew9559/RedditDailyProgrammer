using Solution.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//[2015-10-26] Challenge #238 [Easy] Consonants and Vowels
//https://www.reddit.com/r/dailyprogrammer/comments/3q9vpn/20151026_challenge_238_easy_consonants_and_vowels/

namespace Solution.Problems
{
    public class _2015_10_26_Easy : IRunSolution
    {
        public void Execute()
        {
            List<char> alphabet = new List<char>();
            for(char c = 'a'; c <= 'z'; c++)
            {
                alphabet.Add(c);
            }
            for (char c = 'A'; c <= 'Z'; c++)
            {
                alphabet.Add(c);
            }

            Console.WriteLine("Please enter constants and vowels only");
            var input = Console.ReadLine();
            input.ToCharArray();
            
            foreach (var letter in input)
            {
                if (CheckIfNotVowel(letter) == true && CheckIfNotConstant(letter) == true)
                {
                    Console.WriteLine("Please restart the program and enter only constants and vowels");
                    return;
                }
            }

            //randomize vowels and constants into real letters including capital letters
            Random randomCharacter = new Random();
            randomCharacter.Next()
            foreach (var letter in input)
            {
                randomCharacter
            }

            //output results

        }


        public bool CheckIfNotVowel(char input)
        {
            bool isNotVowel = "aeiouAEIOU".IndexOf(input) < 0;
            return isNotVowel;
        }

        public bool CheckIfNotConstant(char input)
        {
            bool isNotConstant = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ".IndexOf(input) < 0;
            return isNotConstant;
        }
    }
}

