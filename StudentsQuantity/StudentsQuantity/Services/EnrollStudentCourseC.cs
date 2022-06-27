using StudentsQuantity.Entities;

namespace StudentsQuantity.Services
{
    internal class EnrollStudentCourseC : IEnrollStudent
    {
        private char CourseId = 'C';

        public Student EnrollStudent(int id)
        {
            return new Student(id, CourseId);
        }
    }
}
