using System;
using Solution.Interface;

namespace Solution.Problems
{
    public class _2015_11_02_Easy : IRunSolution
    {
        public void Execute()
        {
            Console.WriteLine("Please enter a number to play Game of Threes with");
            var number = Console.ReadLine();

            var numberConverted = int.Parse(number);
            int remainder = 0;

            while (numberConverted > 1)
            {
                remainder = numberConverted % 3 == 0 ? 0 : numberConverted % 3 == 1 ? -1 : 1;

                Console.WriteLine("{0}: {1}", numberConverted, remainder);

                numberConverted = (numberConverted + remainder) / 3;
            }
        }
    }
}
