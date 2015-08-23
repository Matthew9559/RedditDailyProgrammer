using System;
using System.Collections.Generic;
using System.Configuration;
using Solution.Interface;
using Solution.Helpers;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            var answers = new List<IRunSolution>();

            if (ConfigurationManager.AppSettings["Problem001"].ParseBoolValue())
                answers.Add(new _2015_08_17_Easy() as IRunSolution);

            //Check for Problems to run and display each's answer
            if (answers != null && answers.Count > 0)
            {
                foreach (var test in answers)
                {
                    test.Execute();
                }
            }

            Console.ReadLine();
        }
    }
}
