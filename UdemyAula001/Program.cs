using System;

namespace UdemyAula001
{
    class Program
    {
        static void Main(string[] args)
        {
            int rented;
            int roomnum;
            string name;
            string email;
            Room[] rooms = new Room[10];

            Console.Write("How many rooms will be rented? ");
            rented = int.Parse(Console.ReadLine());

            for (int n = 0; n < rented; n++)
            {
                Console.WriteLine("");
                Console.WriteLine("Rent #" + (n+1) + ":");
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Email: ");
                email = Console.ReadLine();
                Console.Write("Room: ");
                roomnum = int.Parse(Console.ReadLine());
                rooms[roomnum] = new Room { Name = name, Email = email, RoomNum = roomnum };
            }

            Console.WriteLine("");
            Console.WriteLine("Busy rooms:");
            for (int n = 0; n < 10; n++)
                if (rooms[n] != null)
                {                 
                    Console.WriteLine(rooms[n].ToString());
                }
            // new comment
            //Console.WriteLine(rooms[roomnum].ToString());
        }
    }
}
