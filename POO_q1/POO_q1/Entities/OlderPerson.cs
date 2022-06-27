namespace POO_q1.Entities
{
    internal class OlderPerson
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string OldestPerson { get; private set; }

        public OlderPerson(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
