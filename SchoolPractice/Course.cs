using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    public class Course
    {
        public string Topic { get; set; }
        public Teacher Instructor { get; set; }
        public List<Student> EnrolledStudents { get; set; }

        public Course(string _topic, Teacher _teacher, List<Student> _students)
        {
            Topic = _topic;
            Instructor = _teacher;
            EnrolledStudents = _students;
        }

        public override string ToString()
        {
            return $"Class: {Topic}, " + "Teacher: " + Instructor.ToString() + " Students: " + EnrolledStudents.ToString();
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

            if (obj.GetType != GetType)
            {
                return false;
            }

            Course courseObj = obj as Course;
            return Topic == courseObj.Topic;
        }

    }
}

