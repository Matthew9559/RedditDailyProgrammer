using Solution.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Challenge #228: Letters in Alphabetical Order
//https://www.reddit.com/r/dailyprogrammer/comments/3h9pde/20150817_challenge_228_easy_letters_in/

namespace Solution
{
    public class _2015_08_17_Easy : IRunSolution
    {
        public List<string> wordsToProcess = new List<string>();

        public void Execute()
        {
            CreateList();
            foreach (var item in wordsToProcess)
            {
                Console.WriteLine(item);
            }
        }


        public void CreateList()
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
    }
}
