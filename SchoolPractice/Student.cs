using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        public static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentID, int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentID;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentID) : this(name, studentID, 0, 0.0) { }

        public Student(string name) : this(name, nextStudentId)
        {
            nextStudentId++;
        }

    }
}
