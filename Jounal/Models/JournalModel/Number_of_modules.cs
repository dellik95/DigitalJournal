using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jounal.Models
{
    public class Number_of_modules
    {
        [Key]
        public short Number_of_modules_ID { get; set; }
        public short NoM { get; set; }
    }
}