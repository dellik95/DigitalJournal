using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jounal.Models
{
    public class Position
    {
        public Position()
        {
            this.Teacher = new HashSet<Teacher>();
        }
        [Key]
        public short Position_ID { get; set; }
        public string PName { get; set; }

        public virtual ICollection<Teacher> Teacher { get; set; }
    }
}