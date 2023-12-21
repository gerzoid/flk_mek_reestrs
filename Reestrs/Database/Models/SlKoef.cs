using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Reestrs.Database.Models
{
    public class SL_KOEF
    {
        [Key]
        public int SL_KOEFId { get; set; }

        [XmlElement("IDSL")]
        [Required]
        public int IDSL { get; set; }

        [XmlElement("Z_SL")]
        [Required]
        [Precision(6,5)]
        public decimal Z_SL { get; set; }
    }
}
