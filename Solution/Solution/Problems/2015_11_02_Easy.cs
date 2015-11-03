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
            //var numberFinal = numberConverted;

            while (numberConverted >= 1)
            {

            }

            //while (numberFinal != 1)
            //{ 
            //    if (numberFinal % 3 == 0)
            //    {
            //        numberFinal =  (numberFinal / 3);
            //        Console.WriteLine("{0}: 0", numberFinal);
            //    }

            //    else if ((numberFinal + 1) % 3 == 0)
            //    {
            //        numberFinal = (numberFinal / 3);
            //        Console.WriteLine("{0}: 1", numberFinal);
            //    }
            //    else
            //    {
            //        numberFinal = ((numberFinal - 1) / 3);
            //        Console.WriteLine("{0}: -1", numberFinal);
            //    }
            //}
        }
    }
}
