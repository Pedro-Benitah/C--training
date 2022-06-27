namespace Vetores.Entities
{
    internal class HotelRooms
    {
        public string Name { get; private set; }
        public string Email { get; private set; }

        public HotelRooms()
        {
        }

        public HotelRooms(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return Name
                + ", "
                + Email;
        }
    }
}
