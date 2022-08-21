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

        public override string ToString()
        {
            return Name + " (Credits: " + NumberOfCredits + ", GPA: " + Gpa + ")";
        }

        public override bool Equals(object obj)
        {
            if (obj == this)
            {
                return true;
            }

            if (obj == null)
            {
                return false;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            Student studentObj = obj as Student;
            return StudentId == studentObj.StudentId;
        }

        public string GetGradeLevel()
        {
            if (NumberOfCredits <= 29)
            {
                return "Freshman";
            }
            else if (NumberOfCredits <= 59)
            {
                return "Sophomore";
            }
            else if (NumberOfCredits <= 89)
            {
                return "Junior";
            }
            else
            {
                return "Senior";
            }
        }

        public void AddGrade(int courseCredits, double grade)
        {
            double totalQualityScore = Gpa * NumberOfCredits;
            totalQualityScore += grade * courseCredits;
            NumberOfCredits += courseCredits;
            Gpa = totalQualityScore / NumberOfCredits;

        }

    }
}
