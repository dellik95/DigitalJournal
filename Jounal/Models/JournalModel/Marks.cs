using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jounal.Models
{
    public class Marks
    {
        [Key]
        public short Marks_ID { get; set; }
        public Nullable<int> Mark { get; set; }
        public short Subjects_ID { get; set; }
        public short Student_ID { get; set; }
        public short Group_ID { get; set; }

        public virtual Groups Groups { get; set; }
        public virtual Students Students { get; set; }
        public virtual Subjects Subjects { get; set; }
    }
}