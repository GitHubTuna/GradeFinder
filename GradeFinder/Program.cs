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
            //Program currently simply calculates student's overall grade based upon course assessment values
            //Test Change
            double attendancePointsEarned=0;
            double homeworkPointsEarned = 0;
            double quizPointsEarned = 0;
            double examPointsEarned = 0;
            double finalExamPointsEarned = 0;

            double attendanceWeight = 0;
            double homeworkWeight = 0;
            double quizWeight = 0;
            double examWeight = 0;
            double finalExamWeight = 0;

            Console.WriteLine("WELCOME GRADE FINDER!!!");
            Console.WriteLine("");
            Console.WriteLine("This program will let you know where you stand in the class currently.");
            Console.WriteLine("What grade do you desire in the class as a letter grade?");
            Console.WriteLine("A, A-, B+, B, B-, C+, C, C-");
            string goalGrade = Console.ReadLine();
            //goalGrade is not used in this program yet.

            Console.WriteLine("");

            Console.WriteLine("Does attendance count as part of your grade?");
            Console.WriteLine("Yes/No");
            string attendanceResponse = Console.ReadLine().ToUpper();
            bool attendance = attendanceResponse == "YES" || attendanceResponse == "Y" ? true : false;

            if (attendance)
            {
                Console.WriteLine("What was the weight of your final grade given to attendance?");
                Console.WriteLine("enter 10% as 10)");
                attendanceWeight = double.Parse(Console.ReadLine()) / 100;

                Console.WriteLine("What percent of the time are you going to attend the class?  For the sake of this applications accuracy please be honest.");
                Console.WriteLine("Enter 100% as 100");
                int attendanceScore = int.Parse(Console.ReadLine());

                attendancePointsEarned = attendanceScore;
            }

            Console.WriteLine("How many Homework assignments does your class have?");
            int numHomework = int.Parse(Console.ReadLine());

            if (numHomework > 0)
            {
                Console.WriteLine("What was the weight of your final grade given to Homework?");
                Console.WriteLine("enter 10% as 10)");
                homeworkWeight = double.Parse(Console.ReadLine()) / 100;

                var homework = new List<Homework>();

                for (int i = 0; i < numHomework ; i++)
                {
                    homework.Add(new Homework { Description = ("HW Assignment " + (i + 1)).ToString(), Score = 0, IsScored = false });
                }

                List<int> homeworkScores = new List<int>();

                Console.WriteLine("What were your scores on these assignments? ");
                Console.WriteLine("enter as 80, 90, 85, 70)");
                char[] Delimiters = new char[] { ',' };
                string[] Input = Console.ReadLine().Split(Delimiters, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < Input.Length; i++)
                {
                    homework[i].Score = int.Parse(Input[i]);
                    homework[i].IsScored = true;
                }

                double averageHomeworkScore = homework.Where(o => o.IsScored == true).Average(o => o.Score);

                homeworkPointsEarned = averageHomeworkScore ;

            }

            Console.WriteLine("How many quizzes does your class have?");
            int numQuiz = int.Parse(Console.ReadLine());

            if (numQuiz > 0)
            {
                Console.WriteLine("What was the weight of your final grade given to Quiz?");
                Console.WriteLine("enter 20% as 20)");
                quizWeight = double.Parse(Console.ReadLine()) / 100;

                var Quiz = new List<Quiz>();

                for (int i = 0; i < numQuiz; i++)
                {
                    Quiz.Add(new Quiz { Description = ("HW Assignment " + (i + 1)).ToString(), Score = 0, IsScored = false });
                }

                List<int> QuizScores = new List<int>();

                Console.WriteLine("What were your scores on these assignments? ");
                Console.WriteLine("enter as 80, 90, 85, 70)");
                char[] Delimiters = new char[] { ',' };
                string[] Input = Console.ReadLine().Split(Delimiters, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < Input.Length; i++)
                {
                    Quiz[i].Score = int.Parse(Input[i]);
                    Quiz[i].IsScored = true;
                }

                double averageQuizScore = Quiz.Where(o => o.IsScored == true).Average(o => o.Score);

                quizPointsEarned = averageQuizScore ;

            }

            Console.WriteLine("How many exams does your class have not including final exams?");
            int numExams=int.Parse(Console.ReadLine());

            if (numExams > 0)
            {
                Console.WriteLine("What was the weight of your final grade given to exams?");
                Console.WriteLine("enter 20% as 20)");
                examWeight = double.Parse(Console.ReadLine())/100;

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

                double averageExamScore = exams.Where(o=>o.IsScored==true).Average(o => o.Score);

                examPointsEarned = averageExamScore;

            }

            Console.WriteLine("How many Final Exams does your class have not including final Final Exams?");
            int numFinalExams = int.Parse(Console.ReadLine());

            if (numFinalExams > 0)
            {
                Console.WriteLine("What was the weight of your final grade given to Final Exams?");
                Console.WriteLine("enter 40% as 40)");
                finalExamWeight = double.Parse(Console.ReadLine()) / 100;

                var FinalExams = new List<FinalExam>();

                for (int i = 0; i < numFinalExams; i++)
                {
                    FinalExams.Add(new FinalExam { Description = ("Final " + (i + 1)).ToString(), Score = 0, IsScored = false });
                }

                List<int> FinalExamsScores = new List<int>();

                Console.WriteLine("What were your scores on these Final Exams? ");
                Console.WriteLine("enter as 80, 90, 85, 70)");
                char[] Delimiters = new char[] { ',' };
                string[] Input = Console.ReadLine().Split(Delimiters, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < Input.Length; i++)
                {
                    FinalExams[i].Score = int.Parse(Input[i]);
                    FinalExams[i].IsScored = true;
                }

                double averageFinalExamsScore = FinalExams.Where(o => o.IsScored == true).Average(o => o.Score);

                finalExamPointsEarned = averageFinalExamsScore;

            }

            double overallClassScore = finalExamPointsEarned * finalExamWeight + homeworkPointsEarned *homeworkWeight + quizPointsEarned * quizWeight  + attendancePointsEarned * attendanceWeight  + examPointsEarned * examWeight;

            AssessmentHelper aHelper = new AssessmentHelper();
            string letterGrade=aHelper.GetLetterGrade(overallClassScore);
            Console.WriteLine("You currently have " + overallClassScore + "% in the class.  Your current letter grade: " + letterGrade + ".");
            Console.ReadLine();
        }
    }
}
