using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jounal.Models
{
    public class Statuss
    {
        public Statuss()
        {
            this.TeacherSubjectsStatus = new HashSet<TeacherSubjectsStatus>();
        }

        [Key]
        public short Statuss_ID { get; set; }
        public string StatName { get; set; }

        public virtual ICollection<TeacherSubjectsStatus> TeacherSubjectsStatus { get; set; }
    }
}