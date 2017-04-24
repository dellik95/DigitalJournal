using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jounal.Models
{
    public class Students
    {
        public Students()
        {
            this.Marks = new HashSet<Marks>();
        }
        [Key]
        public short Student_ID { get; set; }
        public string LName { get; set; }
        public string FName { get; set; }
        public string SName { get; set; }
        public short Group_ID { get; set; }
        public short Cours_ID { get; set; }

        public virtual Cours Cours { get; set; }
        public virtual Groups Groups { get; set; }
       public virtual ICollection<Marks> Marks { get; set; }
    }
}