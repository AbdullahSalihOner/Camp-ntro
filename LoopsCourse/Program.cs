using System;

namespace LoopsCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            string course1 = "java";
            string course2 = "Sowftvare Developer";
            string course3 = "Beginner Course";

            string[] courses = new string[] { "Pyhton", "Sowftvare Developer", "Beginner Course", "Java" };
            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }
            foreach (string course in courses)
            {
                Console.WriteLine(course);
            }
        }
    }
}
