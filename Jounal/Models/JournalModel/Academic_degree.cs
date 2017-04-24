using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jounal.Models
{
    public partial class Academic_degree
    {
       public Academic_degree()
        {
            this.Teacher = new HashSet<Teacher>();
        }
        [Key]
        public short Academic_degree_ID { get; set; }
        public string AcademicDegree { get; set; }

        public virtual ICollection<Teacher> Teacher { get; set; }
    }
}