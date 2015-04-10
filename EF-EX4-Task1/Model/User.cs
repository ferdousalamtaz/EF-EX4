using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_EX4_Task1.Model
{
    public class User
    {
        public User()
        {
            Meetings= new List<Meeting>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        // Organizer (0/1) <-----> OrganizerFor(*)
        [InverseProperty("Organizer")]
        public List<Meeting> OrganizerFor { get; set; }


        // Participants (*) <-----> Meetings(*)
        [InverseProperty("Participants")]
        public List<Meeting> Meetings { get; set; }

        
    }
}
