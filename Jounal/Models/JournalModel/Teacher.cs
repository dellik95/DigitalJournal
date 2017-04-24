using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jounal.Models
{
    public class Teacher
    {
        public Teacher()
        {
            this.Authorizations = new HashSet<Authorizations>();
            this.TeacherCathedra = new HashSet<TeacherCathedra>();
            this.TeacherSubjectsStatus = new HashSet<TeacherSubjectsStatus>();
        }
        [Key]
        public short Teacher_ID { get; set; }
        public string LName { get; set; }
        public string FName { get; set; }
        public string SName { get; set; }
        public short Position_ID { get; set; }
        public short Academic_degree { get; set; }
       

        public virtual Academic_degree Academic_degree1 { get; set; }
         public virtual ICollection<Authorizations> Authorizations { get; set; }
        public virtual Position Position { get; set; }
        public virtual ICollection<TeacherCathedra> TeacherCathedra { get; set; }

         public virtual ICollection<TeacherSubjectsStatus> TeacherSubjectsStatus { get; set; }
    }
}