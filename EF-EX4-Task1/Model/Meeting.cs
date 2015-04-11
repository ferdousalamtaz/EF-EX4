using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_EX4_Task1.Model
{
    public class Meeting
    {
        public Meeting()
        {
            Participants = new List<User>();
            Agenda = new Agenda();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        // Organizer (0/1) <-----> OrganizerFor(*)

        [ForeignKey("Organizer")]
        public int? OrganizerId { get; set; }

        [InverseProperty("OrganizerFor")]
        public User Organizer { get; set; }

        // Participants (*) <-----> Meetings(*)
        [InverseProperty("Meetings")]
        public List<User> Participants { get; set; }



        //Room(1/0) <-----> MeetingsHeld(*)
        public int? Room { get; set; }

        //Meeting(1) <--- Agends(1)
        public Agenda Agenda { get; set; }

    }
}
