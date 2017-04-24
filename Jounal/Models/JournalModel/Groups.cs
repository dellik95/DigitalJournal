using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jounal.Models
{
    public class Groups
    {
        public Groups()
        {
            this.GroupsSubjects = new HashSet<GroupsSubjects>();
            this.Marks = new HashSet<Marks>();
            this.Students = new HashSet<Students>();
        }
        [Key]
        public short Group_ID { get; set; }
        public string NumGroup { get; set; }

        public virtual ICollection<GroupsSubjects> GroupsSubjects { get; set; }
        public virtual ICollection<Marks> Marks { get; set; }
        public virtual ICollection<Students> Students { get; set; }
    }
}