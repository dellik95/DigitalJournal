using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jounal.Models
{
    public class Curriculum
    {
        [Key]
        public short Curriculum_ID { get; set; }
        public string CurName { get; set; }
    }
}