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

            Console.WriteLine("Please enter constants and vowels only");
            var input = Console.ReadLine();
            input.ToCharArray();




            //error hanndling for non c's and v's
            foreach (var letter in input)
            {
                if (CheckIfNotVowel(letter) == true && CheckIfNotConstant(letter) == true)
                {
                    Console.WriteLine("Please restart the program and enter only constants and vowels");
                    return;
                }
            }


            //ranzomize vowels and constants into real letters including capital letters
            var things = 0;


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

