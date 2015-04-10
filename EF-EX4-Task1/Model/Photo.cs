using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EF_EX4_Task1.Model
{
    public class Photo
    {
        public int Id { get; set; }

        [ForeignKey("PhotoOf")]
        public int UserId { get; set; }

        public User PhotoOf { get; set; }
    }
}
