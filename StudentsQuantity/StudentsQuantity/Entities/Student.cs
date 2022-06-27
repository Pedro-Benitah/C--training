namespace StudentsQuantity.Entities
{
    internal class Student
    {
        public int Id { get; set; }
        public char Course { get; set; }

        public Student(int id, char course)
        {
            Id = id;
            Course = course;
        }
    }
}
