using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jounal.Models
{
    public class TeacherSubjectsStatus
    {
        [Key]
        public short TeacherSubjects_ID { get; set; }
        public short Teacher_ID { get; set; }
        public short Subjects_ID { get; set; }
        public short Statuss_ID { get; set; }

        public virtual Statuss Statuss { get; set; }
        public virtual Subjects Subjects { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}