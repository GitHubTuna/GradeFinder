using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add code to ask what assessment types the student has
            //Prompt only for Assessments that exist

            Console.WriteLine("How many exams do you have before your final?");
            int numExams=int.Parse(Console.ReadLine());

            if (numExams > 0)
            {
                Console.WriteLine("What was the weight of your final grade given to these exams?");
                Console.WriteLine("enter 20% as 20)");
                int weight = int.Parse(Console.ReadLine());

                var exams = new List<Exam>();

                for (int i = 0; i < numExams; i++)
                {
                    exams.Add(new Exam { Description = ("Test " + (i + 1)).ToString(), Score = 0, IsScored = false });
                }

                List<int> examScores = new List<int>();

                Console.WriteLine("What were your scores on these exams? ");
                Console.WriteLine("enter as 80, 90, 85, 70)");
                char[] Delimiters = new char[] { ',' };
                string[] Input = Console.ReadLine().Split(Delimiters, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < Input.Length; i++)
                {
                    exams[i].Score = int.Parse(Input[i]);
                    exams[i].IsScored = true;
                }

                for (int i = 0; i < exams.Count; i++)
                {
                    //Ternary operartor 
                    //Condition == Value ? Value When True : Value When False
                    string status = 
                        exams[i].IsScored == true 
                                ? 
                                exams[i].Description + " has a score of " + exams[i].Score + "."
                                : 
                                "You have not yet taken " + exams[i].Description + " a score of 0 will be used within the calculation for this exam.";

                    Console.WriteLine(status);
                }

                Console.ReadLine();
                
            }

        }
    }
}
