using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jounal.Models
{
    public class Cours
    {
         public Cours()
        {
            this.Students = new HashSet<Students>();
        }
        [Key]
        public short Cours_ID { get; set; }
        public short NumCours { get; set; }

        public virtual ICollection<Students> Students { get; set; }
    }
}