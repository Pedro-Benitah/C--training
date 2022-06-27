using System;
using StudentsQuantity.Entities;
using StudentsQuantity.Services;
using StudentsQuantity.Entities.Enums;

namespace StudentsQuantity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            OnlineCourses onlineCourseA = new OnlineCourses();
            OnlineCourses onlineCourseB = new OnlineCourses();
            OnlineCourses onlineCourseC = new OnlineCourses();

            StudentRegister studentRegister = new StudentRegister();

            try
            {
                Console.Write("Enter the number of courses you want to submit: ");
                int x = int.Parse(Console.ReadLine());
                for (int i = 0; i < x; i++)
                {
                    Courses course = (Courses)Enum.Parse(typeof(Courses), $"{i}");
                    Console.Write($"How many students for course {course}? ");

                    n = int.Parse(Console.ReadLine());
                    for (int j = 0; j < n; j++)
                    {
                        int studentId = int.Parse(Console.ReadLine());
                        switch (i)
                        {
                            case 0:
                                studentRegister.AdressStudent(onlineCourseA, studentId, new EnrollStudentCourseA());
                                break;
                            case 1:
                                studentRegister.AdressStudent(onlineCourseA, studentId, new EnrollStudentCourseB());
                                break;
                            case 2:
                                studentRegister.AdressStudent(onlineCourseA, studentId, new EnrollStudentCourseC());
                                break;
                        }
                        
                    }
                }
                Console.WriteLine(studentRegister.TotalStudents(onlineCourseA, onlineCourseB, onlineCourseC));
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred:");
                Console.WriteLine(e);
            }
        }
    }
}
