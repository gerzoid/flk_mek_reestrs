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
    public class LEK_DOSE
    {
        [Key]
        public int LEK_DOSEId { get; set; }

        [XmlElement("COL_INJ")]
        [Required]
        public int COL_INJ { get; set; }

        [XmlElement("DOSE_INJ")]
        [Required]
        [Precision(14,7)]
        public decimal DOSE_INJ { get; set; }

        [XmlElement("ED_IZM")]
        [StringLength(3)]
        [Required]
        public string ED_IZM { get; set; }

        [XmlElement("METHOD_INJ")]
        [StringLength(3)]
        [Required]
        public string METHOD_INJ { get; set; }
    }
}
