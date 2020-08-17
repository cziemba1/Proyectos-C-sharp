using System;
using System.Collections.Generic;

namespace EventDemo
{
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