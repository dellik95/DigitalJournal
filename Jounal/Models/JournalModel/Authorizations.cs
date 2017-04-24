using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jounal.Models
{
    public class Authorizations
    {
        [Key]
        public short Authorizations_ID { get; set; }
        public string Ligin { get; set; }
        public string Pass { get; set; }
        public short Teacher_ID { get; set; }

        public virtual Teacher Teacher { get; set; }
    }
}