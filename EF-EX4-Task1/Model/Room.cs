using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_EX4_Task1.Model
{
    class Room
    {
        public int Id { get; set; }
        public string NumberOfPerticipants { get; set; }

        public List<Meeting> MeetingsHeld { get; set; }
    }
}
