using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EF_EX4_Task1.Model;

namespace EF_EX4_Task1.DAL
{
    class CalenderContext: DbContext 
    {
        public CalenderContext()
            : base("name=CalContext")
        {
            Database.SetInitializer(new CalenderContextInitializer());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Room> Rooms { get;set;}
    }
}
