using System.Collections.Generic;
using StudentsQuantity.Entities;

namespace StudentsQuantity.Services
{
    internal class StudentRegister
    {
        private IEnrollStudent _enrollStudent;

        public void AdressStudent(OnlineCourses onlineCourses,int studentID, IEnrollStudent enrollStudent)
        {
            _enrollStudent = enrollStudent;
            onlineCourses.AddStudents(_enrollStudent.EnrollStudent(studentID));
        }

        public string TotalStudents(params OnlineCourses[] ids)
        {
            HashSet<int> students = new HashSet<int>();

            foreach (OnlineCourses onlineCourse in ids)
            {
                foreach(Student student in onlineCourse.students)
                {
                    students.Add(student.Id);
                }
            }
            
            return "Total students: " + students.Count;
        }
    }
}
