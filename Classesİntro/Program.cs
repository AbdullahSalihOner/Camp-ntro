using System;

namespace Classesİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course1 = new Course();
            course1.CourseName = "Pyhton";
            course1.Teacher = "Salih";
            course1.WatchTime = 76;

            Course course2 = new Course();
            course2.CourseName = "C#";
            course2.Teacher = "Salih";
            course2.WatchTime = 76;

            Course course3 = new Course();
            course3.CourseName = "Java";
            course3.Teacher = "Salih";
            course3.WatchTime = 76;

            Course[] courses = new Course[] { course1, course2, course3 };

            foreach (var course in courses)
            {
                Console.WriteLine(course.CourseName + "-->" + course.Teacher);
            }

            //Console.WriteLine(course3.CourseName+"-->"+course3.Teacher);
        }
    }
    class Course
    {
        public string CourseName { get; set; }
        public string Teacher { get; set; }
        public int WatchTime { get; set; }

    }
}
