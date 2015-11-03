using Solution.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

//Challenge #228: Letters in Alphabetical Order
//https://www.reddit.com/r/dailyprogrammer/comments/3h9pde/20150817_challenge_228_easy_letters_in/

namespace Solution
{
    public class _2015_08_17_Easy : IRunSolution
    {
        internal List<string> wordsToProcess = new List<string>();

        public void Execute()
        {
            CreateList();

            foreach (var word in wordsToProcess)
            {
                var order = IsInOrder(word);
                if (order == "IN ORDER")
                {
                    Console.WriteLine("{0} IN ORDER", word);
                }
                else if (order == "REVERSE ORDER")
                {
                    Console.WriteLine("{0} IN REVERSE ORDER", word);
                }
                else
                {
                    Console.WriteLine("{0} NOT IN ORDER", word);
                }
            }
        }

        private void CreateList()
        {
            wordsToProcess.Add("billowy");
            wordsToProcess.Add("biopsy");
            wordsToProcess.Add("chinos");
            wordsToProcess.Add("defaced");
            wordsToProcess.Add("chintz");
            wordsToProcess.Add("sponged");
            wordsToProcess.Add("bijoux");
            wordsToProcess.Add("abhors");
            wordsToProcess.Add("fiddle");
            wordsToProcess.Add("begins");
            wordsToProcess.Add("abhors");
            wordsToProcess.Add("chimps");
            wordsToProcess.Add("wronged");
        }

        private string IsInOrder(string wordToCheck)
        {
            char[] check = wordToCheck.ToCharArray();
            char[] reverseCheck = wordToCheck.ToCharArray();

            Array.Sort(check);
            Array.Reverse(reverseCheck);

            if (check.SequenceEqual(wordToCheck.ToCharArray()))
            {
                return "IN ORDER";
            }
            else if (string.Concat(wordToCheck.ToCharArray().OrderByDescending(c => c)) == wordToCheck)
            {
                return "REVERSE ORDER";
            }
            else
            {
                return "NOT IN ORDER";
            }
        }
    }
}