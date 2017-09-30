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

            Console.WriteLine("How many exams did you have before your final");
            int numExams=int.Parse(Console.ReadLine());

            if (numExams > 0)
            {
                Console.WriteLine("What was the weight of your final grade given to these exams?");
                Console.WriteLine("enter 20% as 20)");
                int weight = int.Parse(Console.ReadLine());

                var exams = new List<Exam>();

                for (int i = 0; i < numExams; i++)
                {
                    exams.Add(new Exam { Description = ("Test " + (i+1)).ToString(), Score = -999 });
                }

                List<int> examScores = new List<int>();

                Console.WriteLine("What were your scores on these exams? ");
                Console.WriteLine("enter as 80, 90, 85, 70)");
                char[] Delimiters = new char[] { ',' };
                string[] Input = Console.ReadLine().Split(Delimiters, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < Input.Length; i++)
                {
                    exams[i].Score = int.Parse(Input[i]);
                }

                for (int i = 0; i < exams.Count; i++)
                {
                    if (exams[i].Score == -999)
                    { 
                        Console.WriteLine("Exam to be adjusted to 0: " + exams[i].Description + " " + exams[i].Score);
                    }
                }

                int untakenExams = exams.Where(o => o.Score == -999).Count();

                if (untakenExams > 0)
                {
                    //Received null error on this update when all exams had a score
                    // Updates First records only as we might guess exams.Where(o => o.Score == -999).FirstOrDefault().Score = 0;
                    foreach (Exam ex in exams.Where( ex=> ex.Score == -999))
                    {
                        ex.Score = 0;
                    }

                }
                for (int i = 0; i < exams.Count; i++)
                {
                    Console.WriteLine(exams[i].Description + " " + exams[i].Score);
                }

                Console.WriteLine("You have " + untakenExams + " untaken exams, correct?");
                Console.ReadLine();
                //Code continues...
            

            }

        }
    }
}
