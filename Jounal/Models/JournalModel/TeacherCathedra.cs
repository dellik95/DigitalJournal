using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jounal.Models
{
    public class TeacherCathedra
    {
        [Key]
        public short TeacherCathedra_ID { get; set; }
        public short Teacher_ID { get; set; }
        public short Cathedra_ID { get; set; }

        public virtual Cathedra Cathedra { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}