using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CollegeClassModel history = new CollegeClassModel("History 101", 3);
            CollegeClassModel math = new CollegeClassModel("Calculus 201", 2);

            //history.EnrollmentFull += History_EnrollmentFull;

            history.EnrollmentFull += CollegeClass_EnrollmentFull;
            

            history.SignUpStudents("Claudia Ziemba").PrintToConsole();
            history.SignUpStudents("Julian Alberto").PrintToConsole();
            history.SignUpStudents("Marco J").PrintToConsole();
            history.SignUpStudents("Esther Z").PrintToConsole();
            history.SignUpStudents("Luli Louless").PrintToConsole();
            Console.WriteLine();

            math.EnrollmentFull += CollegeClass_EnrollmentFull;

            //math.EnrollmentFull += Math_EnrollmentFull;

            math.SignUpStudents("Claudia Ziemba").PrintToConsole();
            math.SignUpStudents("Julian Alberto").PrintToConsole();
            math.SignUpStudents("Marco J").PrintToConsole();

            Console.ReadLine();
        }

        private static void CollegeClass_EnrollmentFull(object sender, string e)
        {

            CollegeClassModel model = (CollegeClassModel) sender;
            Console.WriteLine();
            //Console.WriteLine($"The enrollment is full for {e}");
            Console.WriteLine($"{model.CourseTitle}: full.");
            Console.WriteLine();
        }


        //private static void Math_EnrollmentFull(object sender, string e)
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("The enrollment is full for math.");
        //    Console.WriteLine();
        //}

        //private static void History_EnrollmentFull(object sender, string e)
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("The enrollment is full for history.");
        //    Console.WriteLine();
        //}
    }

    public static class ConsoleHelpers
    {
        public static void PrintToConsole(this string message)
        {
            Console.WriteLine(message);
        }
    }

    public class CollegeClassModel
    {
        public event EventHandler<string> EnrollmentFull;
        public List<string> enrolledStudents { get; set; } = new List<string>();
        public List<string> waitingList { get; set; } = new List<string>();

        public string CourseTitle { get; set; }
        public int MaximunStudents { get; set; }

        public CollegeClassModel(string title, int maximunStudents)
        {
            CourseTitle = title;
            MaximunStudents = maximunStudents;
        }

        public string SignUpStudents(string studentName)
        {
            string output = "";

            if (enrolledStudents.Count < MaximunStudents)
            {
                enrolledStudents.Add(studentName);
                output = $"{studentName} was enrolled in {CourseTitle}.";

                if (enrolledStudents.Count == MaximunStudents)
                {
                    EnrollmentFull?.Invoke(this, $"{CourseTitle} enrollment is now full.");
                }
            }
            else
            {
                waitingList.Add(studentName);
                output = $"{studentName} was added to the waiting list in {CourseTitle}.";
            }

            return output;
        }
    }
}
