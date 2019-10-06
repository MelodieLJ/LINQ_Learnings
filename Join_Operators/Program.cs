using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Join_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Course> courses = new List<Course>();
            courses.Add(new Course { CourseID = 1, CourseName = "Art" });
            courses.Add(new Course { CourseID = 2, CourseName = "Programming" });
            courses.Add(new Course { CourseID = 3, CourseName = "Music" });

            List<Student> students = new List<Student>();
            students.Add(new Student { StudentName = "Mel", CourseID = 2, StudentID = 123 });
            students.Add(new Student { StudentName = "Art", CourseID = 1, StudentID = 234 });


            var query = (from c in courses
                         join s in students
                         on c.CourseID equals s.CourseID
                         select new
                         {
                             s.StudentName,                     
                             c.CourseName
                         });

            //var z = students.SelectMany()

            foreach (var x in query)
            {
                Console.WriteLine($"Student Name = {x.StudentName}, Course Name = {x.CourseName}");
            }


        }
    }

    public class Student
    {
        public string StudentName { get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }
    }

    public class Course
    {
        public string CourseName { get; set; }
        public int CourseID { get; set; }
    }
}
