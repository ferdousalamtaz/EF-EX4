using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EF_EX4_Task1.DAL;
using EF_EX4_Task1.Model;

namespace EF_EX4_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (CalenderContext Context = new CalenderContext())
            {
                User user1 = new User();
                user1.Name = "Ferdous";
                Context.Users.Add(user1);
                Context.SaveChanges();

                User user2 = new User();
                user2.Name = "dous";
                Context.Users.Add(user2);
                Context.SaveChanges();

                //Add a Meeting
                Meeting meeting1 = new Meeting();
                meeting1.Name = "Meeting";
                Context.Meetings.Add(meeting1);
                Context.SaveChanges();
                
                //Add another Meeting
                Meeting meeting2 = new Meeting();
                meeting2.Name = "Meeting 2";
                Context.Meetings.Add(meeting2);
                Context.SaveChanges();


                // Add an organizer for the meting
                meeting1.Organizer = user1;


                meeting1.Participants.Add(user2);
                meeting1.Participants.Add(user1);
                meeting2.Participants.Add(user2);


                //Add a Photo
                Photo p1 = new Photo();
                Context.Photos.Add(p1);


                p1.UserId = user2.Id;

                Context.SaveChanges();


                //Add a Room
                Room r1 = new Room();


            }
            Console.WriteLine("Yes");
            Console.ReadLine();
        }
    }
}
