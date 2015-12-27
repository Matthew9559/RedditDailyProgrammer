using Solution.Interface;
using System;

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

            if (CheckForInvalidCharacters(input) == true)
            {
                Console.WriteLine("Please re-run the program and enter constants or vowels only");
                Console.ReadLine();
                return;
            }

            var randomInstance = new Random();

            var result = ConvertIntoConstantsAndVariables(input, randomInstance);

            Console.WriteLine(result);
        }

        public bool CheckIfVowel(char input)
        {
            bool isVowel = "aeiouAEIOU".IndexOf(input) > 0;
            return isVowel;
        }

        public bool CheckIfConstant(char input)
        {
            bool isConstant = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ".IndexOf(input) > 0;
            return isConstant;
        }

        public bool CheckForInvalidCharacters(string input)
        {
            foreach (var letter in input)
            {
                if (CheckIfVowel(letter) == false && CheckIfConstant(letter) == false)
                {
                    return true;
                }
            }
            return false;
        }

        public string ConvertIntoConstantsAndVariables(string input, Random randomInstance)
        {
            string result = "";
            char[] alphabetVowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            char[] alphabetConstants = new char[] { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
            var alphabetVowelsCount = alphabetVowels.Length;
            var alphabetConstantsCount = alphabetConstants.Length;

            foreach (var letter in input)
            {
                bool isUpper = char.IsUpper(letter);

                if (isUpper == true && letter == 'V')
                {
                    var nextLetterPosition = randomInstance.Next(alphabetVowelsCount);
                    var tempValue = alphabetVowels[nextLetterPosition];
                    char.ToUpper(tempValue);
                    result = result + tempValue;
                }
                else if (isUpper == true && letter == 'C')
                {
                    var nextLetterPosition = randomInstance.Next(alphabetConstantsCount);
                    var tempValue = alphabetConstants[nextLetterPosition];
                    char.ToUpper(tempValue);
                    result = result + tempValue;
                }
                else if (isUpper == false && letter == 'v')
                {
                    var nextLetterPosition = randomInstance.Next(alphabetVowelsCount);
                    var tempValue = alphabetVowels[nextLetterPosition];
                    result = result + tempValue;
                }
                else if (isUpper == false && letter == 'c')
                {
                    var nextLetterPosition = randomInstance.Next(alphabetConstantsCount);
                    var tempValue = alphabetConstants[nextLetterPosition];
                    result = result + tempValue;
                }
            }
            return result;
        }
    }
}

