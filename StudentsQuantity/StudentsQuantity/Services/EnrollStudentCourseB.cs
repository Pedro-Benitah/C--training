using StudentsQuantity.Entities;

namespace StudentsQuantity.Services
{
    internal class EnrollStudentCourseB : IEnrollStudent
    {
        private char CourseId = 'B';

        public Student EnrollStudent(int id)
        {
            return new Student(id, CourseId);
        }
    }
}
