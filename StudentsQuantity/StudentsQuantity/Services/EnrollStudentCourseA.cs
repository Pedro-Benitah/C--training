using StudentsQuantity.Entities;

namespace StudentsQuantity.Services
{
    internal class EnrollStudentCourseA : IEnrollStudent
    {
        private char CourseId = 'A';

        public Student EnrollStudent(int id)
        {
            return new Student(id, CourseId);
        }
    }
}
