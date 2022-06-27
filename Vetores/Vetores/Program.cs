using System;
using Vetores.Entities;

namespace Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numRooms;

            HotelRooms[] rooms = new HotelRooms[10];

            Console.Write("How many rooms will be rented? ");
            numRooms = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numRooms; i++)
            {
                Console.WriteLine($"\nRent #{i}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int num = int.Parse(Console.ReadLine());
                rooms[num] = new HotelRooms(name, email);
            }

            Console.WriteLine("\nBusy rooms:");
            for(int i = 0; i < rooms.Length; i++)
            {
                if (rooms[i] != null)
                {
                    Console.WriteLine(i + ": " + rooms[i]);
                }
            }
        }
    }
}
