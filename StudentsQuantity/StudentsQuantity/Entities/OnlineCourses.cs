using System.Collections.Generic;

namespace StudentsQuantity.Entities
{
    internal class OnlineCourses
    {
        public List<Student> students { get; set; } = new List<Student>();

        public void AddStudents(Student student)
        {
            students.Add(student);
        }

        public void RemoveStudents(Student student)
        {
            students.Remove(student);
        }
    }
}
