using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyAula001
{
    class Room
    {
        private String name;
        public String Name {  get { return name; } set { name = value; } }
        private String email;
        public String Email  {  get { return email; } set { email = value; }  }
        private int roomnum;
        public int RoomNum  {  get { return roomnum; } set { roomnum = value; } }

        public override String ToString()
        {
            return roomnum + ": " + name + ", " + email;
        }
    }
}
