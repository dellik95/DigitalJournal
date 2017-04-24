using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jounal.Models
{
    public class Subjects
    {
        public Subjects()
        {
            this.GroupsSubjects = new HashSet<GroupsSubjects>();
            this.Marks = new HashSet<Marks>();
            this.TeacherSubjectsStatus = new HashSet<TeacherSubjectsStatus>();
        }
        [Key]
        public short Subjects_ID { get; set; }
        public string SubName { get; set; }

        public virtual ICollection<GroupsSubjects> GroupsSubjects { get; set; }
        public virtual ICollection<Marks> Marks { get; set; }
        public virtual ICollection<TeacherSubjectsStatus> TeacherSubjectsStatus { get; set; }
    }
}