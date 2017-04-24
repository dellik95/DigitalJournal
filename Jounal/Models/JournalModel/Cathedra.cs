using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jounal.Models
{
    public class Cathedra
    {
         public Cathedra()
        {
            this.TeacherCathedra = new HashSet<TeacherCathedra>();
        }
        [Key]
        public short Cathedra_ID { get; set; }
        public string CathName { get; set; }

         public virtual ICollection<TeacherCathedra> TeacherCathedra { get; set; }
    }
}