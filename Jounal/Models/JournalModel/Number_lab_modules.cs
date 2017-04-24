using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jounal.Models
{
    public class Number_lab_modules
    {
        [Key]
        public short Number_lab_modules_ID { get; set; }
        public short NlM { get; set; }
    }
}