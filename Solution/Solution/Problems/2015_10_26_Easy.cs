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
            const string lowerAlphabetVowels = "aeiou";
            const string upperAlphabetVowels = "AEIOU";
            const string lowerAlphabetConstants = "bcdfghjklmnpqrstvwxyz";
            const string upperAlphabetConstants = "BCDFGHJKLMNPQRSTVWXYZ";

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

            string result = "";

            foreach (var letter in input)
            {
                bool isUpper = char.IsUpper(letter);
                if (isUpper)
                {
                    result = GetRandomCharacter(letter);
                }
                else
                {

                }
            }

            //output results

        }

        public char GetRandomCharacter(string alphabet, char letter)
        {
            Random rng = new Random();
            int lengthOfAlphabet = alphabet.Length;
            
            return input;
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

